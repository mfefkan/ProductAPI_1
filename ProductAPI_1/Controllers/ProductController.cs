using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OrderAPI.APIRequest;
using OrderAPI.APIResponseModels;
using OrderAPI.DTO;
using OrderAPI.Models.Context;
using OrderAPI.Models.Entities;
using RabbitMQ.Client;
using System.Text;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        MyContext _db;
        IMemoryCache _memoryCache;
        public ProductController(MyContext db, IMemoryCache mc)
        {
            _db = db;
            _memoryCache = mc;
        }


        [HttpGet]
        public List<ProductDTO> GetProducts(string? category = null)
        {
            
            var cachedProducts = _memoryCache.Get<List<ProductDTO>>("products");
            if (cachedProducts != null)
            {
                if (string.IsNullOrEmpty(category))
                {
                    return cachedProducts;
                }
                else
                {
                    return cachedProducts.Where(p => p.Category == category).ToList();
                }
            }

            
            var products = new List<Product>();

            if (string.IsNullOrEmpty(category))
            {
                products = _db.Products.ToList();
            }
            else
            {
                products = _db.Products.Where(p => p.Category == category).ToList();
            }

            
            var productDTOs = products.Select(p => new ProductDTO
            {
                Category = p.Category,
                Description = p.Description,
                UnitPrice = p.UnitPrice,
                Unit = p.Unit,
                ID = p.ID
            }).ToList();

            
            _memoryCache.Set("products", productDTOs, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
            });

            return productDTOs;
        }

        #region İlk Hali
        //if (category == null)
        //{
        //    List<ProductDTO> productDTOs = _db.Products.Select(x => new ProductDTO
        //    {
        //        Category = x.Category,
        //        Description = x.Description,
        //        UnitPrice = x.UnitPrice,
        //        Unit = x.Unit,
        //        ID = x.ID
        //    }).ToList();
        //    return productDTOs;
        //}
        //else
        //{
        //    List<ProductDTO> productDTOs1 = _db.Products.Where(x => x.Category == category).Select(x => new ProductDTO
        //    {
        //        Category = category,
        //        Description = x.Description,
        //        UnitPrice = x.UnitPrice,
        //        Unit = x.Unit,
        //        ID = x.ID
        //    }).ToList();
        //    return productDTOs1;
        //}
        #endregion



        [HttpPost]
        public int CreateOrder(CreateOrderRequest newOrderReq)
        {

            #region İlkHali
            List<Product> products = new List<Product>();

            products = newOrderReq.Products.Select(x => new Product
            {
                Description = x.Description,
                UnitPrice = x.UnitPrice,
                Unit = x.Unit,
                Category = x.Category
            }).ToList();

            Order newOrder = new Order
            {
                CustomerEmail = newOrderReq.CustomerEmail,
                CustomerName = newOrderReq.CustomerName,
                CustomerGSM = newOrderReq.CustomerGSM,
                Products = products
            };

            foreach (ProductDTO item in newOrderReq.Products)
            {
                Product productFromDB = _db.Products.Find(item.ID);

                newOrder.TotalAmonut += item.UnitPrice;

                if (productFromDB != null && productFromDB.Unit >= 1)
                {
                    if (productFromDB.Unit < item.Unit)
                    {
                        throw new Exception($"{item.Description} unit is not enough for your requested amount");
                    }
                    productFromDB.Unit -= item.Unit;
                    _db.Products.Update(productFromDB);
                }
                else
                {
                    throw new Exception("Product unit is not enough.");
                }

            }

            _db.Orders.Add(newOrder);
            _db.SaveChanges();

            ConnectionFactory factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "SendMail",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = $"Dear {newOrder.CustomerName}, your order has been created successfully.";
                string email = newOrderReq.CustomerEmail;
                byte[] body = Encoding.UTF8.GetBytes($"{message} Email adresi: {email}");

                channel.BasicPublish(exchange: "",
                                     routingKey: "SendMail",
                                     basicProperties: null,
                                     body: body);
            }

            return newOrder.ID;
            #endregion
        }




    }
}

