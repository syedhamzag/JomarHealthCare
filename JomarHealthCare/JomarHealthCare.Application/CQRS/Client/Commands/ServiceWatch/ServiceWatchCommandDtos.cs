using MediatR;
using JomarHealthCare.Application.DataModels.Watch;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ServiceWatch;

public record CreateServiceWatchCommand(ClientServiceWatchDataModel DataModel) : IRequest<ClientServiceWatchDataModel>;
public record UpdateServiceWatchCommand(ClientServiceWatchDataModel DataModel) : IRequest<bool>;

public class DeleteServiceWatchCommand : IRequest<bool>
{
    public int Id { get; set; }
}
