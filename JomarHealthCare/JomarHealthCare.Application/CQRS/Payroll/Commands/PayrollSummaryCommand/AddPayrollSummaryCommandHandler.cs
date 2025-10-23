using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand
{
    public class AddPayrollSummaryCommandHandler: IRequestHandler<AddPayrollSummaryCommand, PayrollSummary>
    {

        private readonly IPayrollSummaryRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public AddPayrollSummaryCommandHandler(
            IUnitOfWork unitOfWork,
            IPayrollSummaryRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<Domain.Entities.PayrollSummary> Handle(AddPayrollSummaryCommand request, CancellationToken cancellationToken)
        {
            var payrollSummary = new Domain.Entities.PayrollSummary
            {
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                CategoryofStaff = request.CategoryofStaff,
                TypeofStaffService = request.CategoryofStaff,
                StaffClass = request.StaffClass,
                Staff = request.Staff,
                CompanyId = _userIdentityService.CompanyId
            };

            await _repository.AddAsync(payrollSummary, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return payrollSummary;
        }
  
    }
}
