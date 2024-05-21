using ApotheekApp.Business.Services;
using ApotheekApp.Data;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace ApotheekApp.Tests
{
    public abstract class UnitTestBase
    {
        protected IServiceProvider _services;
        private DataContext? _dataContext;

        public UnitTestBase()
        {
            var collection = new ServiceCollection();

            collection.AddDbContext<DataContext>(
                options =>
                    options
                        .UseSqlServer()//TODO: add your connection string
            );
            collection.AddScoped<IClientService, ClientService>();
            collection.AddScoped<IEmployeeService, EmployeeService>();
            collection.AddScoped<IEmployeeRepository, EmployeeRepository>();
            collection.AddScoped<IMedicineService, MedicineService>();
            //collection.AddScoped<IPrescriptionService, PrescriptionService>();
            collection.AddScoped<UserManager<AppUser>>();
            collection.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<DataContext>();
            collection.AddLogging();

            _services = collection.BuildServiceProvider();

            Task.WaitAll(TestStart());
        }

        protected abstract Task SetupDatabase(DataContext context);

        protected Task PreDisposeDatabase(DataContext context) => Task.CompletedTask;

        protected Task PostDisposeDatabase() => Task.CompletedTask;

        private async Task TestStart()
        {
            _dataContext = _services.GetRequiredService<DataContext>();
            await _dataContext.Database.EnsureDeletedAsync();
            await _dataContext.Database.EnsureCreatedAsync();

            await SetupDatabase(_dataContext);
            await _dataContext.SaveChangesAsync();
        }

        private void RemoveAll()
        {
            RemoveAll<Client>();
            RemoveAll<Employee>();
            RemoveAll<Medicine>();
            RemoveAll<Allergy>();
        }

        private void RemoveAll<T>()
            where T : class
        {
            _dataContext!.RemoveRange(_dataContext.Set<T>());
        }
    }

    public abstract class UnitTestBase<T> : UnitTestBase
        where T : notnull
    {
        protected T _service;

        public UnitTestBase()
            : base()
        {
            _service = _services.GetRequiredService<T>();
        }
    }

}
