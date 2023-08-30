using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;
using IBOShop.Domain.Sales;
using Microsoft.EntityFrameworkCore;

namespace IBOShop.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Sale> Sales { get; set; }

        void Save();
    }
}