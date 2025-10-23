using MediatR;
using JomarHealthCare.Application.DataModels.Client.InterestObjective;

namespace JomarHealthCare.Application.CQRS.Client.Queries.InterestObjective;

public record GetAllInterestAndObjectiveByClientQuery(Guid clientId) : IRequest<ClientInterestAndObjectiveDataModel>;