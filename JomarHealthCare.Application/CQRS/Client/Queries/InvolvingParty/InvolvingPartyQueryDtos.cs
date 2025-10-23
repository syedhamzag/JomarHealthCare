using MediatR;
using JomarHealthCare.Application.DataModels.Client.InvolvingParty;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InvolvingParty;

public record GetClientInvolvingPartyByIdQuery(int id) : IRequest<ClientInvolvingPartyDataModel>;

public record GetAllClientInvolvingPartyByClientQuery(Guid clientId) : IRequest<List<ClientInvolvingPartyDataModel>>;