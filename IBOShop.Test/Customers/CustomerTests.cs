using IBOShop.Domain.Customers;

namespace IBOShop.Test.Customers
{
    public class CustomerTests
    {
        private readonly Customer _customer;
        public CustomerTests()
        {
            _customer = new Customer();
        }
        [Test]
        public void TestSetAndGetId(int Id)
        {
            _customer.Id = Id;
            Assert.That(_customer.Id, Is.EqualTo(Id));
        }
    }
}