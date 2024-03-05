using ApotheekApp.Data.Repositories;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class EmployeeService(EmployeeRepository employeeRepository) : IEmployeeService
    {


        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);
            return employee;
        }

        public Task DeleteEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}