using KariyerNet.Domain.Entities.Authentications;
using KariyerNet.Domain.Entities.Companies;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Infrastructure.Contracts.Persistence.Repositories
{
    public class ApplicationContext : IdentityDbContext<User,Role, int>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
                
        }

        public DbSet<Company> Companies { get; set; }
    }
}
