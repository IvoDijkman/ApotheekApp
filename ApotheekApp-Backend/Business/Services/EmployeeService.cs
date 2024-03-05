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
            await employeeRepository.CreateEmployeeAsync(employee);
            return employee;
        }

        public void DeleteEmployeeAsync(string id)
        {
            employeeRepository.DeleteEmployeeAsync(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAllEmployees();
        }

        public Employee GetEmployeeByIdAsync(string id)
        {
            return employeeRepository.GetEmployeeByIdAsync(id);
        }

        public Employee GetEmployeeByNameAsync(string lastname, DateTime dob, string? firstname)
        {
            return employeeRepository.GetEmployeeByNameAsync(lastname, dob, firstname);
        }

        public Employee UpdateEmployeeAsync(Employee employee)
        {
            return employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}