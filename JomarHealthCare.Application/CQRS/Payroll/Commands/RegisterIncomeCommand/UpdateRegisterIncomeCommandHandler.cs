using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterIncomeCommand
{
    public class UpdateRegisterIncomeCommandHandler : IRequestHandler<UpdateRegisterIncomeCommand, bool>
    {
        private readonly IRegisterIncomeRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRegisterIncomeCommandHandler(
            IUnitOfWork unitOfWork,
            IRegisterIncomeRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(UpdateRegisterIncomeCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var registerIncome = await _repository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (registerIncome == null || registerIncome.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            // Update properties
            registerIncome.IncomeName = request.IncomeName;

            _repository.Update(registerIncome);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
