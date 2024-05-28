using ApotheekApp.Data.Repositories;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);
            _employeeRepository.CreateEmployee(employee);
            await _employeeRepository.SaveChangesAsync();
            return employee;
        }

        public async Task DeleteEmployeeAsync(string id)
        {
            _employeeRepository.DeleteEmployee(id);
            await _employeeRepository.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAllEmployees() => _employeeRepository.GetAllEmployees();

        public async Task<Employee?> GetEmployeeByIdAsync(string id) => await _employeeRepository.GetEmployeeByIdAsync(id);


        public async Task<Employee?> GetEmployeeByNameAsync(string lastname, string? firstname)
            => await _employeeRepository.GetEmployeeByNameAsync(lastname, firstname);

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);
            _employeeRepository.UpdateEmployee(employee);
            await _employeeRepository.SaveChangesAsync();
            return employee;
        }
    }
}