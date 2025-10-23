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
    internal class GetAllRegisterDeductionQueryHandler : IRequestHandler<GetAllRegisterIncome, List<RegisterIncome>>
    {
        private readonly IRegisterIncomeRepository _repository;
        public GetAllRegisterDeductionQueryHandler(IRegisterIncomeRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<RegisterIncome>> Handle(GetAllRegisterIncome request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().ToListAsync(); // This method should return all records.

            return entities.Select(entity => new RegisterIncome
            {
                Id = entity.Id,
                IncomeName = entity.IncomeName,
                CompanyId = entity.CompanyId
            }).ToList();
        }

    }
}
