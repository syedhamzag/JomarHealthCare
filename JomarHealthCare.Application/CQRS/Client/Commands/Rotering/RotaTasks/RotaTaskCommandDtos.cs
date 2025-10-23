using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaTasks;


public record CreateRotaTaskCommand(RotaTaskDataModel DataModel) : IRequest<RotaTaskDataModel>;
public record UpdateRotaTaskCommand(RotaTaskDataModel DataModel) : IRequest<bool>;


public class DeleteRotaTaskCommand : IRequest<bool>
{
    public int Id { get; set; }
}