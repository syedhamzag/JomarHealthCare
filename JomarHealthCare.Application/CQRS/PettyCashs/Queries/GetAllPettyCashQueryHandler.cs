using MediatR;
using Microsoft.EntityFrameworkCore;
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
    internal class GetAllPettyCashQueryHandler : IRequestHandler<GetAllPettyCash, List<PettyCash>>
    {
        private readonly IPettyCashRepository _repository;
        public GetAllPettyCashQueryHandler(IPettyCashRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PettyCash>> Handle(GetAllPettyCash request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().ToListAsync(); // This method should return all records.

            return entities.Select(entity => new PettyCash
            {
                Id = entity.Id,
                Detail = entity.Detail,
                Date = entity.Date,
                Amount = entity.Amount,
                StaffId = entity.StaffId,
                MethodId = entity.MethodId,
                CompanyId = entity.CompanyId
            }).ToList();
        }
    }
}
