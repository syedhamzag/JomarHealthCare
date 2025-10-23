using MediatR;
using JomarHealthCare.Application.CQRS.Hobby.Queries;
using JomarHealthCare.Application.DataModels.Hobby;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashs.Queries
{
    internal class GetByIdPettyCashQueryHandler : IRequestHandler<GetPettyCashById, PettyCash>
    {
        private readonly IPettyCashRepository _repository;
        public GetByIdPettyCashQueryHandler(IPettyCashRepository repository)
        {
            _repository = repository;
        }
        public async Task<PettyCash> Handle(GetPettyCashById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new PettyCash
            {
                Id = entity.Id,
                Detail = entity.Detail,
                Amount = entity.Amount,
                Date = entity.Date,
                StaffId = entity.StaffId,
                MethodId = entity.MethodId,
                CompanyId = entity.CompanyId
            };
        }
    }
}
