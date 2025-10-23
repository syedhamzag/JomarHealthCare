using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Commands
{
    internal class AddCompanyBankCommandHandler: IRequestHandler<AddCompanyBankCommand, CompanyBank>
    {

        private readonly ICompanyBankRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public AddCompanyBankCommandHandler(
            IUnitOfWork unitOfWork,
            ICompanyBankRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<Domain.Entities.CompanyBank> Handle(AddCompanyBankCommand request, CancellationToken cancellationToken)
        {
            var compayBank = new Domain.Entities.CompanyBank
            {
               
                CompanyId = _userIdentityService.CompanyId
            };

            await _repository.AddAsync(compayBank, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return compayBank;
        }
    
    }
}
