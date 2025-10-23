using MediatR;
using Microsoft.EntityFrameworkCore;
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
    internal class GetAllPettyCashByCompanyQueryHandler : IRequestHandler<GetAllPettyCashByCompanyIdQuery, List<PettyCash>>
    {
        private readonly IPettyCashRepository _repository;
        public GetAllPettyCashByCompanyQueryHandler(IPettyCashRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PettyCash>> Handle(GetAllPettyCashByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

            return entities.Select(entity => new PettyCash
            {
                Id = entity.Id,
                Detail = entity.Detail,
                Date = entity.Date,
                StaffId = entity.StaffId,
                Amount = entity.Amount,
                CompanyId = entity.CompanyId
            }).ToList();
        }
    }
}
