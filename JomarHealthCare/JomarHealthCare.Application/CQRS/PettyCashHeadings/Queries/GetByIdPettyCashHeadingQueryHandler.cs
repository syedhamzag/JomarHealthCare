using MediatR;
using JomarHealthCare.Application.CQRS.PettyCashs.Queries;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Queries
{
    internal class GetByIdExpenseLogQueryHandler : IRequestHandler<GetPettyHeadingCashById, PettyCashHeading>
    {
        private readonly IPettyCashHeadingRepository _repository;
        public GetByIdExpenseLogQueryHandler(IPettyCashHeadingRepository repository)
        {
            _repository = repository;
        }
        public async Task<PettyCashHeading> Handle(GetPettyHeadingCashById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new PettyCashHeading
            {
                Id = entity.Id,
                Name = entity.Name,
                IsMethod = entity.IsMethod,
                CompanyId = entity.CompanyId
            };
        }
    }
}
