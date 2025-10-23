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
    internal class GetAllRegisterDeductionQueryHandler : IRequestHandler<GetAllRegisterDeduction, List<RegisterDeduction>>
    {
        private readonly IRegisterDeductionRepository _repository;
        public GetAllRegisterDeductionQueryHandler(IRegisterDeductionRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<RegisterDeduction>> Handle(GetAllRegisterDeduction request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().ToListAsync(); // This method should return all records.

            return entities.Select(entity => new RegisterDeduction
            {
                Id = entity.Id,
                DeductionName = entity.DeductionName,
                CompanyId = entity.CompanyId
            }).ToList();
        }

    }
}
