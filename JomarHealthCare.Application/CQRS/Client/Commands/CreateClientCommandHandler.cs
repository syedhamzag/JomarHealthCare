using MediatR;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Enums;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, bool>
    {
        private readonly IClientRepository _clientRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IUserIdentityService _userIdentityService;
        private readonly IUnitOfWork _unitOfWork;
        public CreateClientCommandHandler(IClientRepository clientRepository, ICompanyRepository companyRepository,
            IUserIdentityService userIdentityService, IUnitOfWork unitOfWork)
        {
            _clientRepository = clientRepository;
            _companyRepository = companyRepository;
            _userIdentityService = userIdentityService;
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Domain.Entities.Client
            {
                ClientId = Guid.NewGuid(),
                UniqueId = $"AHS/CT/{DateTime.Now.ToString("yy")}",
                Firstname = request.Firstname,
                Middlename = request.Middlename,
                Surname = request.Surname,
                Email = request.Email,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                IdNumber = request.IdNumber,
                StartDate = request.StartDate,
                AreaCodeId = request.AreaCodeId,
                TeritoryId = request.TerritoryId,
                CompanyId = request.CompanyId,
                ProfileImage = request.ProfileImage,
                ClientManagerId = request.ClientManagerId,
                StatusId = ClientStatusEnum.Active,
            };

            await _clientRepository.AddAsync(client, cancellationToken);
            var response = await _unitOfWork.SaveChangesAsync(cancellationToken);

            return response > 0;
        }
    }

}

