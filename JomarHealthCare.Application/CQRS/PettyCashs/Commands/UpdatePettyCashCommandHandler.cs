using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashs.Commands
{
    public class UpdatePettyCashCommandHandler: IRequestHandler<UpdatePettyCashCommand, bool>
    {
        private readonly IPettyCashRepository _pettyCashRepository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePettyCashCommandHandler(
            IUnitOfWork unitOfWork,
            IPettyCashRepository pettyCashRepository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _pettyCashRepository = pettyCashRepository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(UpdatePettyCashCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var pettyCash = await _pettyCashRepository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (pettyCash == null || pettyCash.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            // Update properties
            pettyCash.Detail = request.Detail;
            pettyCash.Date = request.Date ?? pettyCash.Date; // Keep existing date if not provided
            pettyCash.StaffId = request.StaffId;
            pettyCash.MethodId = request.MethodId;
            pettyCash.Amount = request.Amount;

             _pettyCashRepository.Update(pettyCash);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }

    }
}
