namespace IBOShop.Test.Employees
{
    public class EmployeeTests
    {
        private readonly Employee _employee;
        public SetUp()
        {
            _employee = new Employee();
        }
        [Test]
        public TestSetAndGetId(int Id)
        {
            _employee.Id = Id;
            Assert.That(_employee.Id, Is.EqualTo(Id));
        }
    }
}