namespace IBOShop.Domain.Common
{
    public interface IProductEntity : IEntity
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
}