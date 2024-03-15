using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data
{
    public class SeedingInfo
    {
        private static void AddMedicine(ModelBuilder modelBuilder) //TODO fix medicine list not wanting to migrate in.
        {
            modelBuilder.Entity<Medicine>(c =>
            {
                c.HasData(new Medicine
                {
                    Id = 1,
                    Name = "Name",
                    Description = "Description",
                    Manual = "Manual",
                    Type = "Type",
                    Stock = 5,
                });
                c.HasData(new Medicine
                {
                    Id = 2,
                    Name = "Name",
                    Description = "Description",
                    Manual = "Manual",
                    Type = "Type",
                    Stock = 12,
                });
            });
        }

        private static void AddAllergy(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allergy>(c =>
            {
                c.HasData(new Allergy
                {
                    Id = 1,
                    Name = "Name",
                    Description = "Description",
                });
                c.HasData(new Allergy
                {
                    Id = 2,
                    Name = "Name",
                    Description = "Description",
                });
            });
        }

        private static void AddClients(ModelBuilder modelBuilder)
        {
            List<Allergy> AllergyList = [
                new Allergy() { Id = 3, Description = "Achoo theres hay here", Name = "Hayfever" },
                       new Allergy() { Id = 4, Description = "Achoo theres hay here", Name = "Hayfever" }
            ];

            modelBuilder.Entity<Client>(c =>
            {
                c.HasData(new Client
                {
                    //Id = "1",
                    FirstName = "Name",
                    LastName = "Lastname",
                    DateOfBirth = new DateTime(),
                    Allergies = AllergyList,
                });
                c.HasData(new Client
                {
                    //Id = "2",
                    FirstName = "Name",
                    LastName = "Lastname",
                    DateOfBirth = new DateTime(),
                    Allergies = { },
                    //Medicine = [new() { MedicineId = 4, Name = "bah", Description = "bahbeh", Manual = "getting wooly now", Type = "sheep", Stock = 33 }],
                });
            });
        }

        private static void AddEmployee(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(c =>
            {
                c.HasData(new Employee
                {
                    //Id = "3",
                    FirstName = "Name",
                    LastName = "Lastname",
                });
                c.HasData(new Employee
                {
                    //Id = "4",
                    FirstName = "Name",
                    LastName = "Lastname",
                });
            });
        }
    }
}