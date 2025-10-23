using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.Rotas;

public record CreateRotaCommand(RotaDataModel DataModel) : IRequest<RotaDataModel>;
public record UpdateRotaCommand(RotaDataModel DataModel) : IRequest<bool>;


public class DeleteRotaCommand : IRequest<bool>
{
    public int Id { get; set; }
}