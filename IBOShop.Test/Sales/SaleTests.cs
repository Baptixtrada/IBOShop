using IBOShop.Common.Date;
using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;
using IBOShop.Domain.Sales;

namespace IBOShop.Test.Sales
{
    [TestFixture]
    public class SaleTests : ISaleTests
    {
        private Sale _sale;
        private readonly DateService _dateService;
        [SetUp]
        public void Setup()
        {
            _sale = new Sale();
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestSetAndGetId(int Id)
        {
            _sale.Id = Id;
            Assert.That(_sale.Id, Is.EqualTo(Id));
        }
        [Test]
        public void TestSetAndGetDate()
        {
            DateTime testDate = _dateService.GetDate();
            _sale.Date = testDate;
            Assert.That(_sale.Date, Is.EqualTo(testDate));
        }
        [Test]
        public void TestSetAndGetCustomer()
        {
            Customer testCustomer = new Customer();
            _sale.Customer = testCustomer;
            Assert.That(_sale.Customer, Is.EqualTo(testCustomer));
        }

        [Test]
        public void TestSetAndGetEmployee()
        {
            Employee testEmployee = new Employee();
            _sale.Employee = testEmployee;
            Assert.That(_sale.Employee, Is.EqualTo(testEmployee));
        }
        [Test]
        public void TestSetAndGetProduct()
        {
            Product testProduct = new Product();
            _sale.Product = testProduct;
            Assert.That(_sale.Product, Is.EqualTo(testProduct));
        }
    }
}