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

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterIncomeQueries
{
    internal class GetByIdRegisterDeductionQueryHandler : IRequestHandler<GetRegisterIncomeById, RegisterIncome>
    {
        private readonly IRegisterIncomeRepository _repository;
        public GetByIdRegisterDeductionQueryHandler(IRegisterIncomeRepository repository)
        {
            _repository = repository;
        }
        public async Task<RegisterIncome> Handle(GetRegisterIncomeById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new RegisterIncome
            {
                Id = entity.Id,
                IncomeName = entity.IncomeName,
                CompanyId = entity.CompanyId
            };
        }
    }
}
