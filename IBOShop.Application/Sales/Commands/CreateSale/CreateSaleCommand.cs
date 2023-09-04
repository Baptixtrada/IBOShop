using IBOShop.Application.Interfaces;
using IBOShop.Application.Sales.Commands.CreateSale.Factory;
using IBOShop.Common.Date;
using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;
using IBOShop.Domain.Products;
using IBOShop.Domain.Sales;

namespace IBOShop.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommand : ICreateSaleCommand
    {
        private readonly IDateService _dateService;
        private readonly IDatabaseService _databaseService;
        private readonly ISaleFactory _saleFactory;
        private readonly IInventoryService _inventoryService;

        public CreateSaleCommand(IDateService dateService, IDatabaseService databaseService,ISaleFactory saleFactory, IInventoryService inventoryService)
        {
            _dateService = dateService;
            _databaseService = databaseService;
            _saleFactory = saleFactory;
            _inventoryService = inventoryService;
        }

        public void Execute(CreateSaleModel model)
        {
            DateTime date = _dateService.GetDate();
            Customer customer  = _databaseService.Customers.Single(p => p.Id == model.CustomerId);
            Employee employee = _databaseService.Employees.Single(p => p.Id == model.EmployeeId);
            Product product = _databaseService.Products.Single(p => p.Id == model.ProductId);
            var quantity = model.Quantity;
            Sale sale = _saleFactory.Create(date, customer, employee, product, quantity);
            _databaseService.Sales.Add(sale);
            _databaseService.Save();
            _inventoryService.NotifySaleOccured(product.Id, quantity);
        }
    }
}