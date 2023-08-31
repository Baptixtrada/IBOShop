using IBOShop.Application.Interfaces;
using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;
using IBOShop.Domain.Sales;
using IBOShop.Persistence.Customers;
using IBOShop.Persistence.Employees;
using IBOShop.Persistence.Products;
using IBOShop.Persistence.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IBOShop.Persistence
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        private readonly IConfiguration _configuration;
        public DatabaseService(IConfiguration configuration)
        {
            _configuration = configuration;
            Database.EnsureCreated();
        }
        public DbSet<Customer> Customers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Employee> Employees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Product> Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Sale> Sales { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Save()
        {
            this.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("IBOShop");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new CustomerConfiguration().Configure(modelBuilder.Entity<Customer>());
            new EmployeeConfiguration().Configure(modelBuilder.Entity<Employee>());
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());
            new SaleConfiguration().Configure(modelBuilder.Entity<Sale>());
        }
    }
}