namespace IBOShop.Test.Products
{
    public class ProductTests
    {
        private readonly Product _product;
        public SetUp()
        {
            _product = new Product();
        }
        [Test]
        public TestSetAndGetId(int Id)
        {
            _product.Id = Id;
            Assert.That(_product.Id, Is.EqualTo(Id));
        }
    }
}