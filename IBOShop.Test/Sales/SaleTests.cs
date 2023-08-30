using IBOShop.Domain.Sales;

namespace IBOShop.Test.Sales
{
    public class SaleTests
    {
        private readonly Sale _sale;
        public SaleTests()
        {
            _sale = new Sale();
        }
        [Test]
        public void TestSetAndGetId(int Id)
        {
            _sale.Id = Id;
            Assert.That(_sale.Id, Is.EqualTo(Id));
        }

    }
}