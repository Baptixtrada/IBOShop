using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;
using IBOShop.Domain.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBOShop.Persistence.Sales
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date).IsRequired();
            builder.HasOne(x => x.Customer);
            builder.Navigation(x => x.Customer).IsRequired().AutoInclude();
            builder.HasOne(x => x.Employee);
            builder.Navigation(x => x.Employee).IsRequired().AutoInclude();
            builder.HasOne(x => x.Product);
            builder.Navigation(x => x.Product).IsRequired().AutoInclude();
            builder.Property(x => x.TotalPrice).IsRequired().HasPrecision(5, 2);
            builder.HasData(new { Id = 1, Date = DateTime.Parse("2023-01-01"), CustomerId = 1, EmployeeId = 1, ProductId = 1, UnitPrice = 5m, Quantity = 2, TotalPrice = 10m });

        }
    }
}