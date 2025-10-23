using MediatR;
using JomarHealthCare.Application.DataModels.Client.Program;
using JomarHealthCare.Application.DataModels.Pet;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Pet;

public record CreateClientPetCommand(ClientPetDataModel DataModel) : IRequest<ClientPetDataModel>;
public record UpdateClientPetCommand(ClientPetDataModel DataModel) : IRequest<bool>;