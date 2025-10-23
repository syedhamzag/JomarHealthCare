using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.DataModels.Client.Infection;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Infection;

public record GetByClientInfectionControlQuery(Guid clientId) : IRequest<ClientInfectionControlDataModel>;

