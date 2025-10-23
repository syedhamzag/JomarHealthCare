using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.CQRS.Hobby.Commands;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashs.Commands
{
    public class AddPettyCashCommandHandler : IRequestHandler<AddPettyCashCommand, PettyCash>
    {

        private readonly IPettyCashRepository _pettyCashRepository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public AddPettyCashCommandHandler(
            IUnitOfWork unitOfWork,
            IPettyCashRepository pettyCashRepository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _pettyCashRepository = pettyCashRepository;
            _userIdentityService = userIdentityService;
        }

        public async Task<Domain.Entities.PettyCash> Handle(AddPettyCashCommand request, CancellationToken cancellationToken)
        {
            var pettyCash = new Domain.Entities.PettyCash
            {
                Detail = request.Detail,
                Date = request.Date ?? DateTime.UtcNow, // Use current time if not provided
                StaffId = request.StaffId,
                MethodId = request.MethodId,
                Amount = request.Amount,
                CompanyId = _userIdentityService.CompanyId
            };

            await _pettyCashRepository.AddAsync(pettyCash, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return pettyCash;
        }
    }
}
