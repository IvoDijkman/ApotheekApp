using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotheekApp.Business.Services
{
    public class EmployeeServices : IEmployeeService
    {
        public Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
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

        public IEnumerable<Employee> SearchEmployees(string query)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            throw new NotImplementedException();
        }

    }
}
