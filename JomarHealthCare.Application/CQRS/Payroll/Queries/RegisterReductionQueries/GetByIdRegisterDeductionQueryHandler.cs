using MediatR;
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
    internal class GetByIdRegisterDeductionQueryHandler : IRequestHandler<GetRegisterDeductionById, RegisterDeduction>
    {
        private readonly IRegisterDeductionRepository _repository;
        public GetByIdRegisterDeductionQueryHandler(IRegisterDeductionRepository repository)
        {
            _repository = repository;
        }
        public async Task<RegisterDeduction> Handle(GetRegisterDeductionById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new RegisterDeduction
            {
                Id = entity.Id,
                DeductionName = entity.DeductionName,
                CompanyId = entity.CompanyId
            };
        }
    }
}
