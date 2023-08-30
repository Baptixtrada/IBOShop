namespace IBOShop.Test.Customers
{
    public class CustomerTests
    {
        private readonly Customer _customer;
        public SetUp()
        {
            _customer = new Customer();
        }
        [Test]
        public TestSetAndGetId(int Id)
        {
            _customer.Id = Id;
            Assert.That(_customer.Id, Is.EqualTo(Id));
        }
    }
}