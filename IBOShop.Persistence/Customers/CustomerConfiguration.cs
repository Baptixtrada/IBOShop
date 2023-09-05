using IBOShop.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBOShop.Persistence.Customers
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.HasData(new Customer() { Id = 1, Name = "Baptiste Grosjean" }, new Customer() { Id = 2, Name="Xtrada" }, new Customer() { Id=3, Name= "Okay"}) ;
        }
    }
}