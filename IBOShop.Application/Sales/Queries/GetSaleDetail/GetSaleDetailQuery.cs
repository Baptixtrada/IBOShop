namespace IBOShop.Application.Sales.Queries.GetSaleDetail
{
    public class GetSaleDetailQuery : IGetSaleDetailQuery
    {
        private readonly IDatabaseService _databaseService;
        public GetSaleDetailQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public SaleDetailModel Execute(int saleId)
        {
            var sale = _databaseService.Sales.Where(p => p.Id == saleId).Select(p => new SaleDetailModel
            {
                Id = p.Id,
                Date = p.Date,
                CustomerName = p.Customer.Name,
                EmployeeName = p.Employee.Name,
                ProductName = p.Product.Name,
                UnitPrice = p.UnitPrice,
                Quantity = p.Quantity,
                TotalPrice = p.TotalPrice
            }).Single();
            return sale;
        }
    }
}