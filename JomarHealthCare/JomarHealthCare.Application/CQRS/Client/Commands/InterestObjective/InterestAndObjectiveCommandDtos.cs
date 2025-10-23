using MediatR;
using JomarHealthCare.Application.DataModels.Client.InterestObjective;

namespace JomarHealthCare.Application.CQRS.Client.Commands.InterestObjective;

public record CreateInterestAndObjectiveCommand(ClientInterestAndObjectiveDataModel DataModel) : IRequest<ClientInterestAndObjectiveDataModel>;
public record UpdateInterestAndObjectiveCommand(ClientInterestAndObjectiveDataModel DataModel) : IRequest<bool>;