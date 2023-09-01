using IBOShop.Domain.Common;

namespace IBOShop.Domain.Employees
{
    public class Employee : IEntity, IPersonEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
    }
}