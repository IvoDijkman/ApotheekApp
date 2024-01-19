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

namespace ApotheekApp.Business
{
    public static class ServiceProvider
    {
        public static void BuildStandard(this IServiceCollection n)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True";
            InitServices(n);
            n.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString).UseLazyLoadingProxies());
        }


        public static void BuildTest(this IServiceCollection n) => InitServices(n);



        private static void InitServices(IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientServices>();
            services.AddScoped<IEmployeeService, EmployeeServices>();
            services.AddScoped<IMedicineService, MedicineServices>();
        }
    }
}
