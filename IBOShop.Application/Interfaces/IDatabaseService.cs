namespace IBOShop.Application.Interfaces
{
    public class IDatabaseService
    {
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Employee> Employees { get; set; }
        IDbSet<Product> Products { get; set; }
        IDbSet<Sale> Sales { get; set; }
        void Save();
    }
}