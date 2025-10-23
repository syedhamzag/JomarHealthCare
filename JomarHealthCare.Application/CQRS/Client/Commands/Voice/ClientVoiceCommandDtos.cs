using MediatR;
using JomarHealthCare.Application.DataModels.Voice;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Voice;

public record CreateClientVoiceCommand(ClientVoiceDataModel DataModel) : IRequest<ClientVoiceDataModel>;
public record UpdateClientVoiceCommand(ClientVoiceDataModel DataModel) : IRequest<bool>;

public class DeleteClientVoiceCommand : IRequest<bool>
{
    public int Id { get; set; }
}
