using OrderAPI.DTO;

namespace OrderAPI.APIRequest
{
    public class CreateOrderRequest
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerGSM { get; set; }
        public List<ProductDTO> Products{ get; set; }

    }
}
