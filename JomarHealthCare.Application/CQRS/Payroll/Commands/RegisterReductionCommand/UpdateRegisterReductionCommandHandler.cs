using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterReductionCommand
{
    public class UpdateRegisterReductionCommandHandler : IRequestHandler<UpdateRegisterReductionCommand, bool>
    {
        private readonly IRegisterDeductionRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRegisterReductionCommandHandler(
            IUnitOfWork unitOfWork,
            IRegisterDeductionRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(UpdateRegisterReductionCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var register = await _repository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (register == null || register.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            // Update properties
            register.DeductionName = request.DeductionName;

            _repository.Update(register);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
