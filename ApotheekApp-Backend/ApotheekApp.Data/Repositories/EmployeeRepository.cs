using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data.Repositories
{
    public class EmployeeRepository(DataContext dataContext) : IEmployeeRepository
    {
        public Task<Employee?> GetEmployeeByIdAsync(string id) =>
        dataContext.Set<Employee>().Where(x => x.Id == id).FirstOrDefaultAsync() ?? throw new KeyNotFoundException();

        public async Task<Employee?> GetEmployeeByNameAsync(string lastname, string? firstname)
        {
            if (firstname == "")
                return await dataContext.Set<Employee>().SingleOrDefaultAsync(x => x.LastName == lastname);

            return await dataContext.Set<Employee>().SingleOrDefaultAsync(x => x.LastName == lastname && x.FirstName == firstname);
        }

        public Employee CreateEmployee(Employee employee)
        {
            dataContext.Add(employee);
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            dataContext.Update(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees() => dataContext.Set<Employee>();

        public void DeleteEmployee(string id)
        {
            Employee? toDelete = dataContext.Set<Employee>().Where(x => x.Id == id).FirstOrDefault();
            if (toDelete != null)
                dataContext.Remove(toDelete);
        }

        public async Task SaveChanges() => await dataContext.SaveChangesAsync();
    }
}