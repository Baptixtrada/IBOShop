using IBOShop.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBOShop.Persistence.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Price).IsRequired().HasPrecision(5, 2);
            builder.HasData(
                new Product() { Id = 1, Name = "Spaghetti", Price = 5m },
                new Product() { Id = 2, Name = "Lasagne", Price = 5m }
            );
        }
    }
}