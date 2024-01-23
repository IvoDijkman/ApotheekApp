using Business.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Get Employees by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Employee GetEmployeeByIdAsync(int id);

        /// <summary>
        /// Get Employees by first name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Employee GetEmployeeByNameAsync(string name);

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
        public Task<Employee> UpdateEmployeeAsync(Employee employee);

        /// <summary>
        /// Search Employee
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public IEnumerable<Employee> SearchEmployees(string query);

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
        public Task DeleteEmployeeAsync(int id);
    }
}
