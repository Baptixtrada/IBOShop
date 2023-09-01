namespace IBOShop.Application.Sales.Queries.GetSaleDetail
{
    public interface ISaleDetailModel
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        string CustomerName { get; set; }
        string EmployeeName { get; set; }
        string ProductName { get; set; }
        decimal UnitPrice { get; set; }
        int Quantity { get; set; }
        decimal TotalPrice { get; set; }
    }
}