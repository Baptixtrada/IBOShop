using IBOShop.Domain.Common;

namespace IBOShop.Domain.Employees
{
    public class Employee : IEmployee
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
    }
}