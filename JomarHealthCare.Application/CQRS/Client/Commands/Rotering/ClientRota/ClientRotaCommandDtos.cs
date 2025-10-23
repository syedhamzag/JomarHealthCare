using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.ClientRota;

public record CreateClientRotaCommand(List<ClientRotaDataModel> DataModel) : IRequest<List<ClientRotaDataModel>>;
public record UpdateClientRotaCommand(ClientRotaDataModel DataModel) : IRequest<bool>;