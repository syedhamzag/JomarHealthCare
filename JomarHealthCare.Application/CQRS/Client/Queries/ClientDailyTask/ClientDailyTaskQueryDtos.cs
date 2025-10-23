using MediatR;
using JomarHealthCare.Application.DataModels.ClientDailyTask;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ClientDailyTask;

public record GetClientDailyTaskByIdQuery(int id) : IRequest<ClientDailyTaskModelData>;


public record GetAllDailyTaskByClientIdQuery(Guid clientId) : IRequest<List<ClientDailyTaskModelData>>;
