using IBOShop.Application.Interfaces;
using IBOShop.Domain.Sales;

namespace IBOShop.Application.Sales.Queries
{
    public class GestSalesListQuery
    {
        private readonly IDatabaseService _databaseService;
        public GestSalesListQuery(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public List<Sale> Execute(){
            var sales = _databaseService.Sales.Select(p=>new Sale(){Id=p.Id, Date = p.Date});
            return sales.ToList();
        }
    }
}