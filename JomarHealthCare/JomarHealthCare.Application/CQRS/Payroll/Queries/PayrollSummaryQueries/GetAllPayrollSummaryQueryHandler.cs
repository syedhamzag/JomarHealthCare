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

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.PayrollSummaryQueries
{
    internal class GetAllRegisterIncomeyQueryHandler : IRequestHandler<GetAllPayrollSummary, List<PayrollSummary>>
    {
        private readonly IPayrollSummaryRepository _repository;
        public GetAllRegisterIncomeyQueryHandler(IPayrollSummaryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PayrollSummary>> Handle(GetAllPayrollSummary request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().ToListAsync(); // This method should return all records.

            return entities.Select(entity => new PayrollSummary
            {
                Id = entity.Id,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Staff = entity.Staff,
                StaffClass = entity.StaffClass,
                CategoryofStaff = entity.CategoryofStaff,
                TypeofStaffService = entity.TypeofStaffService,
                CompanyId = entity.CompanyId
            }).ToList();
        }

    }
}
