using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.HistoryFall;


public record CreateHistoryOfFallCommand(HistoryOfFallDataModel DataModel) : IRequest<HistoryOfFallDataModel>;
public record UpdateHistoryOfFallCommand(HistoryOfFallDataModel DataModel) : IRequest<bool>;