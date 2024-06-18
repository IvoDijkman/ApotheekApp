using ApotheekApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Get employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Employee?> GetEmployeeByIdAsync(string id);

        /// <summary>
        /// Search for employee by lastname, ?firstname
        /// </summary>
        /// <param name="lastname"></param>
        /// <param name="dob"></param>
        /// <param name="firstname"></param>
        /// <returns></returns>
        public Task<Employee?> GetEmployeeByNameAsync(string lastname, string? firstname);

        /// <summary>
        /// Create employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee CreateEmployee(Employee employee);

        /// <summary>
        /// Update employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee UpdateEmployee(Employee employee);

        /// <summary>
        /// Get a list of all employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees();

        /// <summary>
        /// Delete an employee
        /// </summary>
        /// <returns></returns>
        public void DeleteEmployee(string id);

        /// <summary>
        /// Save changes to db.
        /// </summary>
        /// <returns></returns>
        public Task SaveChangesAsync();
    }
}
