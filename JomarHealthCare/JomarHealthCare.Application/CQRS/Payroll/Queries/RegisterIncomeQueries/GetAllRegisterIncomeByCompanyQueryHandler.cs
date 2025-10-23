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

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterIncomeQueries
{
    internal class GetAllRegisterIncomeByCompanyQueryHandler : IRequestHandler<GetAllRegisterIncomeByCompanyIdQuery, List<RegisterIncome>>
    {
        private readonly IRegisterIncomeRepository _repository;
        public GetAllRegisterIncomeByCompanyQueryHandler(IRegisterIncomeRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<RegisterIncome>> Handle(GetAllRegisterIncomeByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

            return entities.Select(entity => new RegisterIncome
            {
                Id = entity.Id,
               IncomeName = entity.IncomeName,
                CompanyId = entity.CompanyId
            }).ToList();
        }
   
    }
}
