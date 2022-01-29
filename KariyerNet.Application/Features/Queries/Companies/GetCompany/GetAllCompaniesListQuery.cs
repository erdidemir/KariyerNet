using KariyerNet.Application.Models.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KariyerNet.Application.Features.Queries.Companies.GetCompany
{
   
    public class GetAllCompaniesListQuery : IRequest<IList<CompanyModel>>
    {

      

    }
}
