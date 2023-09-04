namespace IBOShop.Application.Sales.Commands.CreateSale
{
    public interface ICreateSaleModel
    {
        int CustomerId { get; set; }
        int EmployeeId { get; set; }
        int ProductId { get; set; }
        int Quantity { get; set; }
    }
}