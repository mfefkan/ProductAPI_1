namespace OrderAPI.Models.Entities
{
    public class Product:BaseEntity
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public int Unit { get; set; }
        public decimal UnitPrice { get; set; }

        //Relational Properties

        public virtual List<Order> Orders { get; set; }
    }
}
