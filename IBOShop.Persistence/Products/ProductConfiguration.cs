using IBOShop.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBOShop.Persistence.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void ProductConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}