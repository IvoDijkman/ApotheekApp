using Microsoft.AspNet.Identity.EntityFramework;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ApotheekApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Client> Clients {  get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        public DataContext()
        {

        } 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseLazyLoadingProxies().UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True");
//#if DEBUG
//            .LogTo(x => Trace.WriteLine(x));
//#else
//            ;
//#endif
                base.OnConfiguring(options);
            }
        }
    }
}
