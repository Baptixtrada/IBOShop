using IBOShop.Domain.Customers;
using IBOShop.Domain.Products;

namespace IBOShop.Test.Products
{
    [TestFixture]
    public class ProductTests : IProductTests
    {
        private Product _product;

        [SetUp]
        public void Setup()
        {
            _product = new Product();
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestSetAndGetId(int Id)
        {
            _product.Id = Id;
            Assert.That(_product.Id, Is.EqualTo(Id));
        }
        [TestCase("John")]
        [TestCase("Jane")]
        [TestCase("Doe")]
        public void TestSetAndGetName(string name)
        {
            _product.Name = name;
            Assert.That(_product.Name, Is.EqualTo(name));
        }
    }
}