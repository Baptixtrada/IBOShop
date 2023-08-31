using IBOShop.Application.Interfaces;
using IBOShop.Common.Date;

namespace IBOShop.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommand : ICreateSaleCommand
    {
        private readonly IDateService _dateService;
        private readonly IDatabaseService _databaseService;
        private readonly IInventoryService _inventoryService;

        public CreateSaleCommand(IDateService dateService, IDatabaseService databaseService, IInventoryService inventoryService)
        {
            this._dateService = dateService;
            this._databaseService = databaseService;
            this._inventoryService = inventoryService;
        }

        public void Execute(CreateSaleModel model)
        {
            throw new NotImplementedException();
        }
    }
}