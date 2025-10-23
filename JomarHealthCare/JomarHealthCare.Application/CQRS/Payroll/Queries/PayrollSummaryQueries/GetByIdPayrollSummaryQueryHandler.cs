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

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.PayrollSummaryQueries
{
    internal class GetByIdRegisterIncomeQueryHandler : IRequestHandler<GetPayrollSummaryById, PayrollSummary>
    {
        private readonly IPayrollSummaryRepository _repository;
        public GetByIdRegisterIncomeQueryHandler(IPayrollSummaryRepository repository)
        {
            _repository = repository;
        }
        public async Task<PayrollSummary> Handle(GetPayrollSummaryById request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByKeyAsync(request.Id, cancellationToken);
            if (entity == null)
            {
                throw new KeyNotFoundException("Not found");
            }
            return new PayrollSummary
            {
                Id = entity.Id,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Staff = entity.Staff,
                StaffClass = entity.StaffClass,
                CategoryofStaff = entity.CategoryofStaff,
                TypeofStaffService = entity.TypeofStaffService,
                CompanyId = entity.CompanyId
            };
        }
    }
}
