using KariyerNet.Application.Contracts.Persistence.Repositories.Companies;
using KariyerNet.Domain.Entities.Companies;
using KariyerNet.Infrastructure.Contracts.Persistence.Repositories.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Infrastructure.Contracts.Persistence.Repositories.Companies
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
