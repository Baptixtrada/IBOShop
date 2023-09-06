using System;
using IBOShop.Application.Products.Queries;
using IBOShop.Presentation.Products.Models;
using IBOShop.Presentation.Sales.Models;

namespace IBOShop.Presentation.Products.Services
{
	public class ProductService
	{
        private readonly IGetProductsListQuery _getProductsListQuery;
        public ProductService(IGetProductsListQuery getProductsListQuery)
        {
            _getProductsListQuery = getProductsListQuery;
        }

        public Task<ProductModel[]> GetProductsAsync()
        {
            var productList = _getProductsListQuery.Execute();

            var mappedProductList = productList.Select(product => new ProductModel
            {
                Id = product.Id,  // Mappage direct, mais vous pouvez appliquer toute transformation ici
                Name = product.Name.ToUpper(),  // Exemple de transformation: convertir le nom en majuscules
                Price = product.Price * 1.1m  // Exemple de transformation: augmenter le prix de 10%
            }).ToArray();

            return Task.FromResult(mappedProductList);
        }
    }
}

