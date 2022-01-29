using KariyerNet.Application.Contracts.Persistence.Repositories.Commons;
using KariyerNet.Infrastructure.Contracts.Persistence.Repositories;
using KariyerNet.Infrastructure.Contracts.Persistence.Repositories.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));

            services.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));


            return services;
        }
    }
}
