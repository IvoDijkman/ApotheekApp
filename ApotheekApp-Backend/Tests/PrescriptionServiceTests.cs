using ApotheekApp.Data;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Xunit;

namespace ApotheekApp.Tests
{
    [Collection("Database Tests")]
    public class PrescriptionServiceTests : UnitTestBase<IPrescriptionService>
    {
        private Employee _employee;
        private Employee _employee2;

        [Fact]
        public async Task Should_GetAllEmployees()
        {
            var employees = _service.GetAllEmployees();
            Assert.Equal(2, employees.Count());
        }

        [Theory]
        [InlineData("Blablabla", "TestFirstName1")]
        public async Task Should_GetEmployeeById(string id, string expected)
        {
            var employee = await _service.GetEmployeeByIdAsync(id);
            string employeeName = employee!.FirstName;
            Assert.Equal(employeeName, expected);
        }

        [Fact]
        public async Task Should_GetEmployeeByName()
        {
            Employee? foundEmployee = await _service.GetEmployeeByNameAsync("TestLastName1", "TestFirstName1");
            string employeeName = foundEmployee!.LastName;
            Assert.Equal(_employee.LastName, employeeName);
        }

        [Fact]
        public async Task Should_DeleteItemFromDb()
        {
            var toDelete = _employee.LastName;
            await _service.DeleteEmployeeAsync("Blablabla");
            var deletedEmployee = await _service.GetEmployeeByNameAsync(toDelete, "TestFirstName1");
            Assert.Null(deletedEmployee);
        }

        protected override Task SetupDatabase(DataContext context)
        {
            _employee = new Employee
            {
                FirstName = "TestFirstName1",
                LastName = "TestLastName1",
                Id = "Blablabla"
            };
            _employee2 = new Employee
            {
                FirstName = "TestFirstName2",
                LastName = "TestLastName2"
            };
            context.Add(_employee);
            context.Add(_employee2);
            return Task.CompletedTask;
        }
    }
}