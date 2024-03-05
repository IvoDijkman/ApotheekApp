using ApotheekApp.Domain.Models;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Get Employees by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployeeByIdAsync(string id);

        /// <summary>
        /// Get Employees by first name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Employee GetEmployeeByNameAsync(string lastname, DateTime dob, string? firstname);

        /// <summary>
        /// Create a new Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<Employee> CreateEmployeeAsync(Employee employee);

        /// <summary>
        /// Update an existing Employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee UpdateEmployeeAsync(Employee employee);

        /// <summary>
        /// Get list of all Employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees();

        /// <summary>
        /// Delete Employee by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void DeleteEmployeeAsync(string id);
    }
}