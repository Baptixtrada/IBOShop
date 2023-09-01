using IBOShop.Domain.Common;

namespace IBOShop.Domain.Products
{
    public class Product : IEntity, IProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}