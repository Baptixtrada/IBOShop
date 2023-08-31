using IBOShop.Application.Interfaces;
using IBOShop.Domain.Customers;
using IBOShop.Domain.Products;

namespace IBOShop.Application.Products.Queries
{
    public class GetProductsListQuery{
        private readonly IDatabaseService? _databaseService;
        public GetProductsListQuery(IDatabaseService databaseService){
            _databaseService = databaseService;
        }
        public List<Product> Execute(){
            var products = _databaseService!.Products.Select(p=>new Product() { Id = p.Id, Name = p.Name, Price = p.Price });
            return products.ToList();
        }
    }
}