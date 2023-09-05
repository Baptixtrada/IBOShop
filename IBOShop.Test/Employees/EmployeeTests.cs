using IBOShop.Domain.Customers;
using IBOShop.Domain.Employees;

namespace IBOShop.Test.Employees
{
    [TestFixture]
    public class EmployeeTests : IEmployeeTests
    {
        private Employee _employee;

        [SetUp]
        public void Setup()
        {
            _employee = new Employee();
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TestSetAndGetId(int Id)
        {
            _employee.Id = Id;
            Assert.That(_employee.Id, Is.EqualTo(Id));
        }
        [TestCase("John")]
        [TestCase("Jane")]
        [TestCase("Doe")]
        public void TestSetAndGetName(string name)
        {
            _employee.Name  = name;
            Assert.That(_employee.Name, Is.EqualTo(name));
        }
    }
}