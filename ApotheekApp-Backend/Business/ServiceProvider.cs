using ApotheekApp.Business.Services;
using ApotheekApp.Data;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ApotheekApp.Business
{
    public static class ServiceProvider
    {
        public static void BuildStandard(this IServiceCollection n)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekApp_Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True";
            InitServices(n);
            n.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString).UseLazyLoadingProxies());

            n.AddIdentity<AppUser, IdentityRole>()
            .AddEntityFrameworkStores<DataContext>()
            .AddDefaultTokenProviders();
        }

        public static void BuildTest(this IServiceCollection n)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekApp_TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True";
            InitServices(n);
            n.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString).UseLazyLoadingProxies());
        }

        private static void InitServices(IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IMedicineService, MedicineService>();
        }
    }
}