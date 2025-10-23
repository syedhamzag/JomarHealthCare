using MediatR;
using JomarHealthCare.Application.DataModels.Client.Infection;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Infection;


public record CreateInfectionControlCommand(ClientInfectionControlDataModel DataModel) : IRequest<ClientInfectionControlDataModel>;
public record UpdateInfectionControlCommand(ClientInfectionControlDataModel DataModel) : IRequest<bool>;