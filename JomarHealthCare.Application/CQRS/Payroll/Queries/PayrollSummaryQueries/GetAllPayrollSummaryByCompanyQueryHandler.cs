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

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.PayrollSummaryQueries
{
    internal class GetAllPayrollSummaryByCompanyHandler : IRequestHandler<GetAllPayrollSummaryByCompanyIdQuery, List<PayrollSummary>>
    {
        private readonly IPayrollSummaryRepository _repository;
        public GetAllPayrollSummaryByCompanyHandler(IPayrollSummaryRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<PayrollSummary>> Handle(GetAllPayrollSummaryByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var entities = await _repository.Get().Where(x => x.CompanyId == null || x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

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
