using ApplicationLayer;
using ApplicationLayer.DbContext;
using DBMigrator;
using Infrastructure;
using Infrastructure.EntityDbContext;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;
using System.Reflection;

namespace Presentation
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            
            var builder = Host.CreateDefaultBuilder();

            builder.ConfigureServices(services =>
                {
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                    services.AddInfrastructureDI(ConfigurationManager.ConnectionStrings);
                    services.AddApplicationDI();
                    
                });

            var host = builder.Build();

            host.Services.GetService<EntityContext>();

            var app = host.Services.GetService<App>();
            app?.Run();

        }
    }
}
