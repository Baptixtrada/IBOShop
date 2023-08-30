using IBOShop.Domain.Employees;

namespace IBOShop.Test.Employees
{
    public class EmployeeTests
    {
        private readonly Employee _employee;
        public EmployeeTests()
        {
            _employee = new Employee();
        }
        [Test]
        public void TestSetAndGetId(int Id)
        {
            _employee.Id = Id;
            Assert.That(_employee.Id, Is.EqualTo(Id));
        }
    }
}