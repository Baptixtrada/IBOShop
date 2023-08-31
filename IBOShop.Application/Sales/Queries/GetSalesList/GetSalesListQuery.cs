using IBOShop.Application.Interfaces;
using IBOShop.Domain.Sales;

namespace IBOShop.Application.Sales.Queries.GetSalesList
{
    public class GetSalesListQuery : IGetSalesListQuery
    {
        private readonly IDatabaseService _databaseService;
        public GetSalesListQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public List<SalesListModel> Execute()
        {
            var sales = _databaseService.Sales.Select(p => new Sale() { Id = p.Id, Date = p.Date });
            return sales.ToList();
        }
    }
}