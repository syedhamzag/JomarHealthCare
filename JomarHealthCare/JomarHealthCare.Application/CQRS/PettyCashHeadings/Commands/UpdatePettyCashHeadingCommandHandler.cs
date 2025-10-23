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
    public class UpdatePettyCashHeadingCommandHandler: IRequestHandler<UpdatePettyCashHeadingCommand, bool>
    {
        private readonly IPettyCashHeadingRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public UpdatePettyCashHeadingCommandHandler(
            IUnitOfWork unitOfWork,
            IPettyCashHeadingRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<bool> Handle(UpdatePettyCashHeadingCommand request, CancellationToken cancellationToken)
        {
            // Get existing record
            var pettyCash = await _repository.GetByKeyAsync(new object[] { request.Id }, cancellationToken);
            if (pettyCash == null || pettyCash.CompanyId != _userIdentityService.CompanyId)
            {
                return false;
            }

            // Update properties
            pettyCash.Name = request.Name;
            pettyCash.IsMethod = request.IsMethod;

            _repository.Update(pettyCash);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
