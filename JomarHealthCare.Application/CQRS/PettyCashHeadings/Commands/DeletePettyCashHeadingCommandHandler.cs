using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands
{
    public class DeletePayrollSummaryCommandHandler: IRequestHandler<DeletePettyCashHeadingCommand, bool>
    {
        private readonly IPettyCashHeadingRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public DeletePayrollSummaryCommandHandler(
            IUnitOfWork unitOfWork,
            IPettyCashHeadingRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(DeletePettyCashHeadingCommand request, CancellationToken cancellationToken)
        {
            // Optional: Verify the record belongs to the user's company
            var pettyCash = await _repository.GetByKeyAsync(request.Id, cancellationToken);

            if (pettyCash == null || pettyCash.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            _repository.Delete(pettyCash);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    
    }
}
