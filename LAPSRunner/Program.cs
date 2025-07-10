using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Runner.Data;
using Runner.Repository;
using Runner.Repository.Interfaces;
using Runner.Service;
using Runner.Service.Interfaces;
using System.ComponentModel.Design;

namespace LAPSRunner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            using (var scope = host.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<RunnerDbContext>();
                dbContext.Database.Migrate();
            }

            Application.Run(ServiceProvider.GetRequiredService<Runner>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    //services.AddTransient<IHelloService, HelloService>();
                    services.AddSingleton(typeof(RunnerDbContext));
                    services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                    services.AddTransient(typeof(IGenericService<>), typeof(GenericService<>));
                    services.AddTransient<Runner>();
                });
        }
    }
}