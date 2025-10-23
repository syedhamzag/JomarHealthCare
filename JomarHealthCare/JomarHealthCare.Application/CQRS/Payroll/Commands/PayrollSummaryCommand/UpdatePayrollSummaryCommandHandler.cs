using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands
{
    public class UpdatePayrollSummaryCommandHandler: IRequestHandler<UpdatePayrollSummaryCommand, bool>
    {
        private readonly IPayrollSummaryRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePayrollSummaryCommandHandler(
            IUnitOfWork unitOfWork,
            IPayrollSummaryRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(UpdatePayrollSummaryCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var payrollSummary = await _repository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (payrollSummary == null || payrollSummary.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            // Update properties
            payrollSummary.StartDate = request.StartDate;
            payrollSummary.EndDate = request.EndDate;
            payrollSummary.Staff = request.Staff;
            payrollSummary.StaffClass = request.StaffClass;
            payrollSummary.CategoryofStaff = request.CategoryofStaff;
            payrollSummary.TypeofStaffService = request.TypeofStaffService;

            _repository.Update(payrollSummary);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
