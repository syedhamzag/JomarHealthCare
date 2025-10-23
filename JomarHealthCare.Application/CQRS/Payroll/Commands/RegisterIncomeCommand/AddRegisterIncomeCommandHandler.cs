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

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterIncomeCommand
{
    public class AddRegisterIncomeCommandHandler : IRequestHandler<AddRegisterIncomeCommand, RegisterIncome>
    {

        private readonly IRegisterIncomeRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public AddRegisterIncomeCommandHandler(
            IUnitOfWork unitOfWork,
            IRegisterIncomeRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<Domain.Entities.RegisterIncome> Handle(AddRegisterIncomeCommand request, CancellationToken cancellationToken)
        {
            var registerIncome = new Domain.Entities.RegisterIncome
            {
                IncomeName = request.IncomeName,
                CompanyId = request.CompanyId
            };

            await _repository.AddAsync(registerIncome, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return registerIncome;
        }
  
   
    }
}
