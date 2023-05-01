using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.APIRequest;
using OrderAPI.APIResponseModels;
using OrderAPI.DTO;
using OrderAPI.Models.Context;
using OrderAPI.Models.Entities;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        MyContext _db;
        public ProductController(MyContext db)
        {
            _db = db;
        }
         
        [HttpGet]
        public List<ProductDTO> GetProducts(string? category = null)
        {

            if (category == null)
            {
                List<ProductDTO> productDTOs = _db.Products.Select(x => new ProductDTO
                {
                    Category = x.Category,
                    Description = x.Description,
                    UnitPrice = x.UnitPrice,
                    Unit = x.Unit,
                    ID = x.ID
                }).ToList();
                return productDTOs;
            }
            else
            {
                List<ProductDTO> productDTOs1 = _db.Products.Where(x => x.Category == category).Select(x => new ProductDTO
                {
                    Category = category,
                    Description = x.Description,
                    UnitPrice = x.UnitPrice,
                    Unit = x.Unit,
                    ID = x.ID
                }).ToList();
                return productDTOs1;
            }

        }

        [HttpPost]
        public int CreateOrder(CreateOrderRequest newOrderReq) 
        {
            List<Product> products = new List<Product>();

            products = newOrderReq.Products.Select(x => new Product
            {
                Description = x.Description,
                UnitPrice = x.UnitPrice,
                Unit = x.Unit,
                ID = x.ID,
                Category = x.Category
            }).ToList();

            Order newOrder = new Order
            {
                CustomerEmail = newOrderReq.CustomerEmail,
                CustomerName = newOrderReq.CustomerName,
                CustomerGSM = newOrderReq.CustomerGSM,
                Products = products
            };


            _db.Orders.Add(newOrder);

            return newOrder.ID;
        }

       

    }
}
