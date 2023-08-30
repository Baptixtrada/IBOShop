using IBOShop.Domain.Products;

namespace IBOShop.Test.Products
{
    public class ProductTests
    {
        private readonly Product _product;
        public ProductTests()
        {
            _product = new Product();
        }
        [Test]
        public void TestSetAndGetId(int Id)
        {
            _product.Id = Id;
            Assert.That(_product.Id, Is.EqualTo(Id));
        }
    }
}