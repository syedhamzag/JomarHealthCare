using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Capacity;
public record CreateCapacityCommand(CapacityDataModel DataModel) : IRequest<CapacityDataModel>;
public record UpdateCapacityCommand(CapacityDataModel DataModel) : IRequest<bool>;