using System;
using IBOShop.Application.Interfaces;
using IBOShop.Application.Sales.Commands.CreateSale;
using IBOShop.Application.Sales.Commands.CreateSale.Factory;
using IBOShop.Common.Date;
using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;
using IBOShop.Domain.Sales;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.AutoMock;
using Moq.EntityFrameworkCore;

namespace IBOShop.Test.Sales
{
    [TestFixture]
    public class CreateSaleTests : ICreateSaleTests
    {
        private CreateSaleCommand _createSaleCommand;
        private AutoMocker _autoMocker;
        private CreateSaleModel _createSaleModel;
        private Sale _sale;
        private Customer _customer;
        private Employee _employee;
        private Product _product;
        private int _quantity;
        private IDateService _dateService;
        private DateTime _date;


        public void Initialize(int customerId, int employeeId, int productId, int quantity)
        {
            _customer = new Customer() { Id = customerId };
            _employee = new Employee() { Id = employeeId };
            _product = new Product() { Id = productId };
            _quantity = quantity;
            _createSaleModel = new CreateSaleModel()
            {
                CustomerId = customerId,
                EmployeeId = employeeId,
                ProductId = productId,
                Quantity = quantity
            };
            _sale = new Sale();

        }

        [SetUp]
        public void SetUp()
        {
            Initialize(1, 2, 3, 4);
            MockDependencies();
            _createSaleCommand = _autoMocker.CreateInstance<CreateSaleCommand>();
        }

        private void MockDependencies()
        {
            _dateService = new Mock<IDateService>().Object;
            _date = _dateService.GetDate();
            _autoMocker = new AutoMocker();
            _autoMocker.GetMock<IDateService>().Setup(p => p.GetDate()).Returns(_date);
            _autoMocker.GetMock<IDatabaseService>().Setup(p => p.Customers).ReturnsDbSet(new List<Customer> { _customer });
            _autoMocker.GetMock<IDatabaseService>().Setup(p => p.Employees).ReturnsDbSet(new List<Employee> { _employee });
            _autoMocker.GetMock<IDatabaseService>().Setup(p => p.Products).ReturnsDbSet(new List<Product> { _product });
            _autoMocker.GetMock<IDatabaseService>().Setup(p => p.Sales).Returns(_autoMocker.GetMock<DbSet<Sale>>().Object);
            _autoMocker.GetMock<ISaleFactory>().Setup(p => p.Create(_date, _customer, _employee, _product, _quantity)).Returns(_sale);
        }

        [Test]
        public void TestExecuteShouldAddSaleToTheDatabase()
        {

            _createSaleCommand.Execute(_createSaleModel);

            _autoMocker.GetMock<DbSet<Sale>>()
                .Verify(p => p.Add(_sale),
                    Times.Once);
        }

        [Test]
        public void TestExecuteShouldSaveChangesToDatabase()
        {

            _createSaleCommand.Execute(_createSaleModel);

            _autoMocker.GetMock<IDatabaseService>()
                .Verify(p => p.Save(),
                    Times.Once);
        }

        [Test]
        public void TestExecuteShouldNotifyInventoryThatSaleOccurred()
        {

            _createSaleCommand.Execute(_createSaleModel);

            _autoMocker.GetMock<IInventoryService>()
                .Verify(p => p.NotifySaleOccured(
                        _product.Id,
                        _quantity),
                    Times.Once);
        }
    }
}

