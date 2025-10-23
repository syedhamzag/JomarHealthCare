using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Commands
{
    internal class UpdateCompanyBankCommandHandler: IRequestHandler<UpdateCompanyBankCommand, bool>
    {
        private readonly ICompanyBankRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCompanyBankCommandHandler(
            IUnitOfWork unitOfWork,
            ICompanyBankRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(UpdateCompanyBankCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var companyBank = await _repository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (companyBank == null || companyBank.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            // Update properties
            companyBank.BankName = request.BankName;
            companyBank.Title = request.Title;
            companyBank.SortCode = request.SortCode;
            companyBank.IsUKBank = request.IsUKBank;
            companyBank.TransitNo = request.TransitNo;
            companyBank.InstitudionNo = request.InstitudionNo;
            companyBank.IsOperating = request.IsOperating;

            _repository.Update(companyBank);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    
    }
}
