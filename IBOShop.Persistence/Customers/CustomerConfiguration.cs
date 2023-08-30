using IBOShop.Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBOShop.Persistence.Customers
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void CustomerConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}