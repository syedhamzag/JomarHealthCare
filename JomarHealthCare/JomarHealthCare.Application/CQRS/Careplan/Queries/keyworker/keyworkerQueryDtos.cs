using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.keyworker;
public record GetByClientKeyworkerQuery(Guid clientId) : IRequest<KeyworkerDataModel>;
