using KariyerNet.Api;
using KariyerNet.Api.Extentions;
using KariyerNet.Infrastructure.Contracts.Persistence.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args)
            .Build()
            .MigrateDatabase<ApplicationContext>((context, services) =>
            {
                var logger = services.GetService<ILogger<ApplicationContextSeed>>();
                ApplicationContextSeed
                    .SeedAsync(context, logger)
                    .Wait();
            })
            .Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
