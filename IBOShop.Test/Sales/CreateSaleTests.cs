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
	public class CreateSaleTests
	{
		private CreateSaleCommand _createSaleCommand;
		private AutoMocker _autoMocker;
		private CreateSaleModel _createSaleModel;
		private Sale _sale;
		private IDateService _dateService;
		private DateTime _date;
		private const int _customerId = 1;
		private const int _employeeId = 2;
		private const int _productId = 3;
		private const decimal _unitPrice = 1.23m;
		private const int _quantity = 4;

		[SetUp]
		public void SetUp()
		{
			_dateService = new DateService();
			_date = _dateService.GetDate();
			Customer customer = new Customer() { Id = _customerId };
			Employee employee = new Employee() { Id = _employeeId };
			Product product = new Product() { Id = _productId };
			_createSaleModel = new CreateSaleModel() { CustomerId = _customerId, EmployeeId = _employeeId, ProductId = _productId, Quantity = _quantity };
			_sale = new Sale();
			_autoMocker = new AutoMocker();
			_autoMocker.GetMock<IDateService>().Setup(p => p.GetDate()).Returns(_date);
			_autoMocker.GetMock<IDatabaseService>().Setup(p => p.Customers).ReturnsDbSet(new List<Customer> { customer });
			_autoMocker.GetMock<IDatabaseService>().Setup(p => p.Employees).ReturnsDbSet(new List<Employee> { employee });
			_autoMocker.GetMock<IDatabaseService>().Setup(p => p.Products).ReturnsDbSet(new List<Product> { product });
			_autoMocker.GetMock<IDatabaseService>().Setup(p => p.Sales).Returns(_autoMocker.GetMock<DbSet<Sale>>().Object);
			_autoMocker.GetMock<ISaleFactory>()
	.Setup(p => p.Create(
		_date,
		customer,
		employee,
		product,
		_quantity))
	.Returns(_sale);

			_createSaleCommand = _autoMocker.CreateInstance<CreateSaleCommand>();
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
						_productId,
						_quantity),
					Times.Once);
		}
	}
}

