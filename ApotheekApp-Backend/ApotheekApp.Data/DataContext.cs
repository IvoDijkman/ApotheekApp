using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Allergy> Allergy { get; set; }
        public DbSet<ClientMedicine> ClientMedicines { get; set; }

        public DataContext() : base()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseLazyLoadingProxies().UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True");
                base.OnConfiguring(options);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>();

            modelBuilder.Entity<Employee>();

            modelBuilder.Entity<Medicine>()
                .HasKey(e => e.MedicineId);

            modelBuilder.Entity<Allergy>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<ClientMedicine>()
                .HasKey(x => new { x.MedicineId, x.ClientId });

            modelBuilder.Entity<ClientMedicine>().HasOne(x => x.Client).WithMany(x => x.MedicineLink).HasForeignKey(x => x.ClientId);
            modelBuilder.Entity<ClientMedicine>().HasOne(x => x.Medicine).WithMany(x => x.ClientLink).HasForeignKey(x => x.MedicineId);

            modelBuilder.Entity<Client>() //TODO Check if this is the correct way of doing it.
                .HasMany(x => x.Allergies)
                .WithOne()
                .HasForeignKey(x => x.ClientId);

            modelBuilder.Entity<Client>().Navigation(x => x.Allergies).AutoInclude();

            AddMedicine(modelBuilder);
            AddAllergy(modelBuilder);
            AddClients(modelBuilder);
            AddEmployee(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private static void AddMedicine(ModelBuilder modelBuilder) //TODO fix medicine list not wanting to migrate in.
        {
            modelBuilder.Entity<Medicine>(c =>
            {
                c.HasData(new Medicine
                {
                    MedicineId = 1,
                    Name = "Name",
                    Description = "Description",
                    Manual = "Manual",
                    Type = "Type",
                    Stock = 5,
                });
                c.HasData(new Medicine
                {
                    MedicineId = 2,
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
                    ClientId = "1",
                    Description = "Description",
                });
                c.HasData(new Allergy
                {
                    Id = 2,
                    ClientId = "2",
                    Description = "Description",
                });
            });
        }

        private static void AddClients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(c =>
            {
                c.HasData(new Client
                {
                    Id = "1",
                    FirstName = "Name",
                    LastName = "Lastname",
                    DateOfBirth = new DateTime(),
                    Allergies = { },
                });
                c.HasData(new Client
                {
                    Id = "2",
                    FirstName = "Name",
                    LastName = "Lastname",
                    DateOfBirth = new DateTime(),
                    Allergies = { },
                });
            });
        }

        private static void AddEmployee(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(c =>
            {
                c.HasData(new Employee
                {
                    Id = "3",
                    FirstName = "Name",
                    LastName = "Lastname",
                });
                c.HasData(new Employee
                {
                    Id = "4",
                    FirstName = "Name",
                    LastName = "Lastname",
                });
            });
        }
    }
}