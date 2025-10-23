using MediatR;
using JomarHealthCare.Application.DataModels.Watch;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ServiceWatch;

public record GetByClientServiceWatchQuery(Guid clientId) : IRequest<List<ClientServiceWatchDataModel>>;
public record GetByIdClientServiceWatchQuery(int id) : IRequest<ClientServiceWatchDataModel>;