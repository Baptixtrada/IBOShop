using System;
using IBOShop.Presentation.Customers.Models;
namespace IBOShop.Presentation.Customers.Services
{
	public class CustomerService
	{
        private static readonly string[] Customers = new[]
        {
            "Apple", "Banana", "Cherry", "Orange", "Pear"
        };

        public Task<CustomerModel[]> GetCustomersAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new CustomerModel
            {
                Id = index,
                Name = Customers[Random.Shared.Next(Customers.Length)],
            }).ToArray());
        }
	}
}

