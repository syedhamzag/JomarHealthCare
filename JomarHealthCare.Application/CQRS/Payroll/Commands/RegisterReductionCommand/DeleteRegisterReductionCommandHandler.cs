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
    public class DeleteRegisterReductionCommandHandler : IRequestHandler<DeleteRegisterReductionCommand, bool>
    {
        private readonly IRegisterDeductionRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRegisterReductionCommandHandler(
            IUnitOfWork unitOfWork,
            IRegisterDeductionRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(DeleteRegisterReductionCommand request, CancellationToken cancellationToken)
        {
            // Optional: Verify the record belongs to the user's company
            var deleteRegister = await _repository.GetByKeyAsync(request.Id, cancellationToken);

            if (deleteRegister == null || deleteRegister.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            _repository.Delete(deleteRegister);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    
   
    }
}
