using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.OralCares;

public record GetByClientOralCareQuery(Guid clientId) : IRequest<OralCareDataModel>;
