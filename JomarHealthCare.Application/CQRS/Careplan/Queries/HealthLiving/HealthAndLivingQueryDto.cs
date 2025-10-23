using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.HealthLiving;

public record GetByClientHealtAndLivingQuery(Guid clientId) : IRequest<HealthAndLivingDataModel>;

