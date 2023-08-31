namespace IBOShop.Application.Sales.Commands.CreateSale
{
    public interface ICreateSaleCommand{
        void Execute(CreateSaleModel model);
    }
}