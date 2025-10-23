using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Congnitive;

public record GetByClientCongnitiveQuery(Guid clientId) : IRequest<CongnitiveDataModel>;
