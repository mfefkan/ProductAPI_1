namespace OrderAPI.DTO
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
    }
}
