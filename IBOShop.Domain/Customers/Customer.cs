using IBOShop.Domain.Common;

namespace IBOShop.Domain.Customers
{
    public class Customer : ICustomer
    {
        public int Id { get ; set; }
        public string Name { get ; set; }
    }
}