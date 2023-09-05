using IBOShop.Domain.Customers;

namespace IBOShop.Test.Customers
{
    [TestFixture]
    public class CustomerTests : ICustomerTests
    {
        private Customer _customer;

        [SetUp]
        public void Setup()
        {
            _customer = new Customer();
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestSetAndGetId(int Id)
        {
            _customer.Id = Id;
            Assert.That(_customer.Id, Is.EqualTo(Id));
        }
        [TestCase("John")]
        [TestCase("Jane")]
        [TestCase("Doe")]
        public void TestSetAndGetName(string name)
        {
            _customer.Name = name;
            Assert.That(_customer.Name, Is.EqualTo(name));
        }
    }
}