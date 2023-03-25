using ApplicationLayer;
using DBMigrator;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;

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
                });
           
           

            var host = builder.Build();
           

        var app = host.Services.GetService<App>();
            app?.Run();

        }
    }
}
