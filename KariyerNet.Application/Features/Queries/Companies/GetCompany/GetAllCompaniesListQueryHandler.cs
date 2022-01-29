using AutoMapper;
using KariyerNet.Application.Contracts.Persistence.Repositories.Companies;
using KariyerNet.Application.Models.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KariyerNet.Application.Features.Queries.Companies.GetCompany
{
    public class GetAllCompaniesListQueryHandler : IRequestHandler<GetAllCompaniesListQuery, IList<CompanyModel>>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        public GetAllCompaniesListQueryHandler(ICompanyRepository companyRepository,
            IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }
        public async Task<IList<CompanyModel>> Handle(GetAllCompaniesListQuery request, CancellationToken cancellationToken)
        {
            var compaines = await _companyRepository.GetAllAsync();

            return _mapper.Map<IList<CompanyModel>>(compaines);
        }
    }
}
