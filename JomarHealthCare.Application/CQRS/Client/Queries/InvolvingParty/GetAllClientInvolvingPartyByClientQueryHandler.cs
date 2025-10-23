using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.InvolvingParty;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InvolvingParty;

internal class GetAllHobbyByCompanyQueryHandler : IRequestHandler<GetAllClientInvolvingPartyByClientQuery, List<ClientInvolvingPartyDataModel>>
{
    private readonly IClientInvolvingPartyRepository _repository;

    public GetAllHobbyByCompanyQueryHandler(IClientInvolvingPartyRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientInvolvingPartyDataModel>> Handle(GetAllClientInvolvingPartyByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ClientInvolvingPartyDataModel
        {
            ClientInvolvingPartyId = entity.ClientInvolvingPartyId,
            ClientInvolvingPartyItem = entity.ClientInvolvingPartyItem,
            Name = entity.Name,
            Address = entity.Address,
            Email = entity.Email,
            Telephone = entity.Telephone,
            Relationship = entity.Relationship,
            ClientId = entity.ClientId,
        }).ToList();
    }
}