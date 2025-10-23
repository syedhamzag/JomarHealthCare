using MediatR;
using JomarHealthCare.Application.DataModels.Client.InvolvingParty;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InvolvingParty;


internal class GetClientInvolvingPartyByIdQueryHandler : IRequestHandler<GetClientInvolvingPartyByIdQuery, ClientInvolvingPartyDataModel>
{
    private readonly IClientInvolvingPartyRepository _repository;

    public GetClientInvolvingPartyByIdQueryHandler(IClientInvolvingPartyRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientInvolvingPartyDataModel> Handle(GetClientInvolvingPartyByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ClientInvolvingPartyDataModel
        {
            ClientInvolvingPartyId = entity.ClientInvolvingPartyId,
            ClientInvolvingPartyItem = entity.ClientInvolvingPartyItem,
            Name = entity.Name,
            Address = entity.Address,
            Email = entity.Email,
            Telephone = entity.Telephone,
            Relationship = entity.Relationship,
            ClientId = entity.ClientId,
        };
    }
}