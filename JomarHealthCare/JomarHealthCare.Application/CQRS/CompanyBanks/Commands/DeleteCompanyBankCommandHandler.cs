using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Commands
{
    internal class DeleteBankCommandHandler: IRequestHandler<DeleteCompanyBankCommand, bool>
    {
        private readonly ICompanyBankRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBankCommandHandler(
            IUnitOfWork unitOfWork,
            ICompanyBankRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(DeleteCompanyBankCommand request, CancellationToken cancellationToken)
        {
            // Optional: Verify the record belongs to the user's company
            var companyBank = await _repository.GetByKeyAsync(request.Id, cancellationToken);

            if (companyBank == null || companyBank.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            _repository.Delete(companyBank);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
   
    }
}
