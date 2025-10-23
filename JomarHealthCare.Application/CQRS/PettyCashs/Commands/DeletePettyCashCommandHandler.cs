using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashs.Commands
{
    public class DeletePettyCashCommandHandler : IRequestHandler<DeletePettyCashCommand, bool>
    {
        private readonly IPettyCashRepository _pettyCashRepository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public DeletePettyCashCommandHandler(
            IUnitOfWork unitOfWork,
            IPettyCashRepository pettyCashRepository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _pettyCashRepository = pettyCashRepository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(DeletePettyCashCommand request, CancellationToken cancellationToken)
        {
            // Optional: Verify the record belongs to the user's company
            var pettyCash = await _pettyCashRepository.GetByKeyAsync(request.Id, cancellationToken);

            if (pettyCash == null || pettyCash.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            _pettyCashRepository.Delete(pettyCash);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}

