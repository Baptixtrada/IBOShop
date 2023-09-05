using IBOShop.Domain.Common;

namespace IBOShop.Domain.Products
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}