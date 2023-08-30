namespace IBOShop.Persistence.Employees
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void EmployeeConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}