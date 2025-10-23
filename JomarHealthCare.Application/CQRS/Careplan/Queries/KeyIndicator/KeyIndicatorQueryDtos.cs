using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.KeyIndicator;

public record GetByClientKeyIndicatorQuery(Guid clientId) : IRequest<KeyIndicatorDataModel>;
