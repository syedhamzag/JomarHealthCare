using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Consent;

public record GetByClientConsentDataQuery(Guid clientId) : IRequest<ConsentDataModel>;

