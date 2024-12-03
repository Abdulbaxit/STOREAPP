namespace STORE_APP.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CategoryName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Tags { get; set; }
    }
}
