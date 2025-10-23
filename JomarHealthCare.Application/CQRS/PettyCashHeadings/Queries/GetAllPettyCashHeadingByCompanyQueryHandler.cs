using MediatR;
using Microsoft.EntityFrameworkCore;
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
    internal class GetAllPettyCashHeadingByCompanyQueryHandler : IRequestHandler<GetAllPettyCashHeadingByCompanyIdQuery, List<PettyCashHeading>>
    {
        private readonly IPettyCashHeadingRepository _repository;
        public GetAllPettyCashHeadingByCompanyQueryHandler(IPettyCashHeadingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PettyCashHeading>> Handle(GetAllPettyCashHeadingByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

            return entities.Select(entity => new PettyCashHeading
            {
                Id = entity.Id,
                IsMethod = entity.IsMethod,
                Name = entity.Name,
                CompanyId = entity.CompanyId
            }).ToList();
        }
   
    }
}
