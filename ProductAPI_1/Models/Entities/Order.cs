namespace OrderAPI.Models.Entities
{
    public class Order:BaseEntity
    {

        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerGSM { get; set; }
        public decimal TotalAmonut { get; set; }

        //Relational Properties

        public virtual List<Product> Products { get; set; }
    }
}
