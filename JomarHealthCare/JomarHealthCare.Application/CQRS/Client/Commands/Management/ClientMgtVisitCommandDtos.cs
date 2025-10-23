using MediatR;
using JomarHealthCare.Application.DataModels.Management;
using JomarHealthCare.Application.DataModels.Watch;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Management;

public record CreateMgtVisitCommand(ClientMgtVisitDataModel DataModel) : IRequest<ClientMgtVisitDataModel>;
public record UpdateMgtVisitCommand(ClientMgtVisitDataModel DataModel) : IRequest<bool>;

public class DeleteMgtVisitCommand : IRequest<bool>
{
    public int Id { get; set; }
}
