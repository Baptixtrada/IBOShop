namespace IBOShop.Application.Sales.Queries.GetSalesList
{
    public interface IGetSalesListQuery
    {
        List<SalesListModel> Execute();
    }
}