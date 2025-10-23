using MediatR;
using JomarHealthCare.Application.DataModels.Client.HealthCondition;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HealthCondition;

public record GetClientHealthConditionByIdQuery(int id) : IRequest<ClientHealthConditionDataModel>;

public record GetAllClientHealthConditionByClientQuery(Guid clientId) : IRequest<List<ClientHealthConditionDataModel>>;