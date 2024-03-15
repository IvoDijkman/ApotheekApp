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
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True");
                base.OnConfiguring(options);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                            .HasMany(c => c.Allergies).WithMany().UsingEntity(e => e.ToTable("ClientAllergy"));

            modelBuilder.Entity<Client>().Navigation(c => c.Allergies).AutoInclude();

            modelBuilder.Entity<Employee>();

            modelBuilder.Entity<Medicine>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Allergy>();

            base.OnModelCreating(modelBuilder);
        }
    }
}