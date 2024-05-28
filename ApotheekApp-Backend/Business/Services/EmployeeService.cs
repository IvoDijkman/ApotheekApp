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
        public Employee CreateEmployee(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);
            _employeeRepository.CreateEmployee(employee);
            _employeeRepository.SaveChanges();
            return employee;
        }

        public async Task DeleteEmployee(string id)
        {
            _employeeRepository.DeleteEmployee(id);
            await _employeeRepository.SaveChanges();
        }

        public IEnumerable<Employee> GetAllEmployees() => _employeeRepository.GetAllEmployees();

        public async Task<Employee?> GetEmployeeByIdAsync(string id) => await _employeeRepository.GetEmployeeByIdAsync(id);


        public async Task<Employee?> GetEmployeeByNameAsync(string lastname, string? firstname)
            => await _employeeRepository.GetEmployeeByNameAsync(lastname, firstname);

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);
            _employeeRepository.UpdateEmployee(employee);
            await _employeeRepository.SaveChanges();
            return employee;
        }
    }
}