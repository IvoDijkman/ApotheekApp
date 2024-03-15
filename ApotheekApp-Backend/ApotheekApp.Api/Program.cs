using ApotheekApp.Business.Services;
using ApotheekApp.Data;
using ApotheekApp.Data.Repositories;
using ApotheekApp.Domain.Interfaces;

namespace ApotheekApp.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen()
                .AddScoped<IClientService, ClientService>()
                .AddScoped<IMedicineService, MedicineService>()
                .AddScoped(typeof(IRepository<>), typeof(EFRepository<>))
                .AddDbContext<DataContext>()
                .AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}