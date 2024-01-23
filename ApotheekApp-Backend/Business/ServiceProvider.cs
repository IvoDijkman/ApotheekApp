using ApotheekApp.Business.Interfaces;
using ApotheekApp.Data;
using Business.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using ApotheekApp.Domain.Models;

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
            services.AddScoped<IClientService, ClientServices>();
            services.AddScoped<IEmployeeService, EmployeeServices>();
            services.AddScoped<IMedicineService, MedicineServices>();
        }
    }
}
