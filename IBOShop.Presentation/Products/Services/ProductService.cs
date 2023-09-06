using System;
using IBOShop.Application.Products.Queries;
using IBOShop.Presentation.Products.Models;
using IBOShop.Presentation.Sales.Models;

namespace IBOShop.Presentation.Products.Services
{
	public class ProductService
	{
        private readonly IGetProductsListQuery _getProductsListQuery;
        public ProductService(IGetProductsListQuery getProductsListQuery){
            _getProductsListQuery = getProductsListQuery;
        }
        private static readonly string[] Products = new[]
        {
            "Apple", "Banana", "Cherry", "Orange", "Pear"
        };

        public Task<ProductModel[]> GetProductsAsync()
        {
            return _getProductsListQuery.Execute().ToArray();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ProductModel
            {
                Id = index,
                Name = Products[Random.Shared.Next(Products.Length)],
                Price = Math.Round((decimal)Random.Shared.NextDouble() * 100, 2)
            }).ToArray());
        }
    }
}

