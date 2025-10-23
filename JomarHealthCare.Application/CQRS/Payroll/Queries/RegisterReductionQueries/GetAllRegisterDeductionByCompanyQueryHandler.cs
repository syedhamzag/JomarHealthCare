using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Queries;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterReductionQueries
{
    internal class GetAllRegisterDeductionByCompanyQueryHandler : IRequestHandler<GetAllRegisterDeductionByCompanyIdQuery, List<RegisterDeduction>>
    {
        private readonly IRegisterDeductionRepository _repository;
        public GetAllRegisterDeductionByCompanyQueryHandler(IRegisterDeductionRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<RegisterDeduction>> Handle(GetAllRegisterDeductionByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

            return entities.Select(entity => new RegisterDeduction
            {
                Id = entity.Id,
               DeductionName = entity.DeductionName,
                CompanyId = entity.CompanyId
            }).ToList();
        }
   
    }
}
