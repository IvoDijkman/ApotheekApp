using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Allergy> Allergy { get; set; }
        public DbSet<Prescription> Prescription { get; set; }

        public DataContext() : base()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True");
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>()
                            .HasMany(c => c.Allergies).WithMany().UsingEntity(e => e.ToTable("ClientAllergy"))
                            .HasMany(c => c.Prescriptions).WithOne();
            builder.Entity<Client>().Navigation(c => c.Allergies).AutoInclude();

            builder.Entity<Prescription>().HasMany(p => p.Medicines).WithMany().UsingEntity(e => e.ToTable("PrescriptionMedicine"));
            builder.Entity<Prescription>().Navigation(p => p.Medicines).AutoInclude();

            //base.OnModelCreating(modelBuilder);
        }
    }
}