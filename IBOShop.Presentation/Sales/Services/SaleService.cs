using System;
using IBOShop.Presentation.Sales.Models;

namespace IBOShop.Presentation.Sales.Services
{
	public class SaleService
	{
        private static readonly string[] ProductNames = new[]
        {
            "Apple", "Banana", "Cherry", "Orange", "Pear"
        };

        public Task<SaleModel[]> GetSalesAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new SaleModel
            {
                Id = index,
                ProductName = ProductNames[Random.Shared.Next(ProductNames.Length)],
                Quantity = Random.Shared.Next(1, 50),
                Price = Math.Round((decimal)Random.Shared.NextDouble() * 100, 2)
            }).ToArray());
        }

    }
}

