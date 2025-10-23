using MediatR;
using JomarHealthCare.Application.DataModels.Policy;

namespace JomarHealthCare.Application.CQRS.Policy.Queries;

public record GetPolicyByIdQuery(Guid PolicyId) : IRequest<PolicyDataModel>;

public record GetAllPolicyQuery() : IRequest<List<PolicyDataModel>>;