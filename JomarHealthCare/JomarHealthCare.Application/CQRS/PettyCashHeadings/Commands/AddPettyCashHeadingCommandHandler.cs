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

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands
{
    public class AddPettyCashHeadingCommandHandler: IRequestHandler<AddPettyCashHeadingCommand, PettyCashHeading>
    {

        private readonly IPettyCashHeadingRepository _repository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;

        public AddPettyCashHeadingCommandHandler(
            IUnitOfWork unitOfWork,
            IPettyCashHeadingRepository repository,
            IUserIdentityService userIdentityService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userIdentityService = userIdentityService;
        }

        public async Task<Domain.Entities.PettyCashHeading> Handle(AddPettyCashHeadingCommand request, CancellationToken cancellationToken)
        {
            var pettyCash = new Domain.Entities.PettyCashHeading
            {
                Name = request.Name,
                IsMethod = request.IsMethod,   
                CompanyId = _userIdentityService.CompanyId
            };

            await _repository.AddAsync(pettyCash, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return pettyCash;
        }
   
    }
}
