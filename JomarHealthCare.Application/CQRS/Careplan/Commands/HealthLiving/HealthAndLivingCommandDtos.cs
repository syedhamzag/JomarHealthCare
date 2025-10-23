using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.HealthLiving;

public record CreateHealthAndLivingCommand(HealthAndLivingDataModel DataModel) : IRequest<HealthAndLivingDataModel>;
public record UpdateHealthAndLivingCommand(HealthAndLivingDataModel DataModel) : IRequest<bool>;