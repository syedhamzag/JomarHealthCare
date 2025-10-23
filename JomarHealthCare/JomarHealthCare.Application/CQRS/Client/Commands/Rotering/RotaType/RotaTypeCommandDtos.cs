using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaType;


public record CreateRotaTypeCommand(ClientRotaTypeDataModel DataModel) : IRequest<ClientRotaTypeDataModel>;
public record UpdateRotaTypeCommand(ClientRotaTypeDataModel DataModel) : IRequest<bool>;


public class DeleteRotaTypeCommand : IRequest<bool>
{
    public int Id { get; set; }
}