using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.HistoryFall;

public record GetByClientHistoryOfFallQuery(Guid clientId) : IRequest<HistoryOfFallDataModel>;
