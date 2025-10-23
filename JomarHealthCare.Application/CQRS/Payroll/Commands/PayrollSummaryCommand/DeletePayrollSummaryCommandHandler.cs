using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand
{
    public class DeletePayrollSummaryCommandHandler: IRequestHandler<DeletePayrollSummaryCommand, bool>
    {
        private readonly IPayrollSummaryRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public DeletePayrollSummaryCommandHandler(
            IUnitOfWork unitOfWork,
            IPayrollSummaryRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(DeletePayrollSummaryCommand request, CancellationToken cancellationToken)
        {
            // Optional: Verify the record belongs to the user's company
            var payrollSummary = await _repository.GetByKeyAsync(request.Id, cancellationToken);

            if (payrollSummary == null || payrollSummary.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            _repository.Delete(payrollSummary);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    
    }
}
