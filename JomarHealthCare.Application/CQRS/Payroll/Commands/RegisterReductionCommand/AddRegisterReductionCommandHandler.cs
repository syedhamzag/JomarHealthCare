using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterReductionCommand
{
    public class AddRegisterReductionCommandHandler : IRequestHandler<AddRegisterReductionCommand, RegisterDeduction>
    {

        private readonly IRegisterDeductionRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public AddRegisterReductionCommandHandler(
            IUnitOfWork unitOfWork,
            IRegisterDeductionRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<Domain.Entities.RegisterDeduction> Handle(AddRegisterReductionCommand request, CancellationToken cancellationToken)
        {
            var registerIncome = new Domain.Entities.RegisterDeduction
            {
                DeductionName = request.DeductionName,
                CompanyId = request.CompanyId
            };

            await _repository.AddAsync(registerIncome, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return registerIncome;
        }
  
   
    }
}
