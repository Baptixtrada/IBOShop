namespace IBOShop.Test.Sales
{
    public class SaleTests
    {
        private readonly Sale _sale;
        public SetUp()
        {
            _sale = new Sale();
        }
        [Test]
        public TestSetAndGetId(int Id)
        {
            _sale.Id = Id;
            Assert.That(_sale.Id, Is.EqualTo(Id));
        }

    }
}