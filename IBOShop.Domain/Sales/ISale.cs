using IBOShop.Domain.Common;
using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;

namespace IBOShop.Domain.Sales
{
    public interface ISale : IEntity
    {
        DateTime Date { get; set; }
        Customer? Customer { get; set; }
        Employee? Employee { get; set; }
        Product? Product { get; set; }
        decimal UnitPrice { get; set; }
        int Quantity { get; set; }
        decimal TotalPrice { get; set; }
    }
}