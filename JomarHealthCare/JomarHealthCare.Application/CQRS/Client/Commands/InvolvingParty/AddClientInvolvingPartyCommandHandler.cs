using MediatR;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InvolvingParty;

public class AddClientInvolvingPartyCommandHandler : IRequestHandler<AddClientInvolvingPartyCommand, ClientInvolvingParty>
{
    private readonly IClientInvolvingPartyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddClientInvolvingPartyCommandHandler(IClientInvolvingPartyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<ClientInvolvingParty> Handle(AddClientInvolvingPartyCommand request, CancellationToken cancellationToken)
    {
        var data = new ClientInvolvingParty
        {
            Name = request.Name,
            ClientInvolvingPartyItem = request.ClientInvolvingPartyItem,
            Address = request.Address,
            Email = request.Email,
            Telephone = request.Telephone,
            Relationship = request.Relationship,
            ClientId = request.ClientId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}