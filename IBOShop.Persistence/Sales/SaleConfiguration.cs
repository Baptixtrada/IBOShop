using IBOShop.Domain.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IBOShop.Persistence.Sales
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void SaleConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Date)
                .IsRequired();

            HasRequired(p => p.Customer);

            HasRequired(p => p.Employee);

            HasRequired(p => p.Product);

            Property(p => p.TotalPrice)
                .IsRequired()
                .HasPrecision(5, 2);
        }
    }
}