using ApotheekApp.Domain.Models;

namespace ApotheekApp.Data.Repositories
{
    public class EmployeeRepository(DataContext dataContext)
    {
        public Employee GetEmployeeByIdAsync(string id) =>
        dataContext.Set<Employee>().Where(x => x.Id == id).FirstOrDefault() ?? throw new KeyNotFoundException();

        public Employee GetEmployeeByNameAsync(string lastname, DateTime dob, string? firstname)
        {
            if (firstname == "")
                return (Employee)dataContext.Set<Employee>().Where(x => x.LastName == lastname);

            return (Employee)dataContext.Set<Employee>().Where(x => x.LastName == lastname && x.FirstName == firstname);
        }

        public async Task<Employee> CreateEmployeeAsync(Employee employee)
        {
            await dataContext.AddAsync(employee);
            return employee;
        }

        public Employee UpdateEmployeeAsync(Employee employee)
        {
            dataContext.Update(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees() => dataContext.Set<Employee>();

        public void DeleteEmployeeAsync(string id)
        {
            Employee? toDelete = dataContext.Set<Employee>().Where(x => x.Id == id).FirstOrDefault();
            if (toDelete != null)
                dataContext.Remove(toDelete);
        }

        public async Task SaveChanges() => await dataContext.SaveChangesAsync();
    }
}