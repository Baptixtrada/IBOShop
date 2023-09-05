using IBOShop.Domain.Products;

namespace IBOShop.Application.Products.Queries
{
    public interface IGetProductsListQuery
    {
        List<Product> Execute();
    }
}