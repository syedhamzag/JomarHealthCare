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
    internal class GetAllPayrollSummaryQueryHandler : IRequestHandler<GetAllPettyCashHeading, List<PettyCashHeading>>
    {
        private readonly IPettyCashHeadingRepository _repository;
        public GetAllPayrollSummaryQueryHandler(IPettyCashHeadingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PettyCashHeading>> Handle(GetAllPettyCashHeading request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().ToListAsync(); // This method should return all records.

            return entities.Select(entity => new PettyCashHeading
            {
                Id = entity.Id,
                Name = entity.Name,
                IsMethod = entity.IsMethod,
                CompanyId = entity.CompanyId
            }).ToList();
        }

    }
}
