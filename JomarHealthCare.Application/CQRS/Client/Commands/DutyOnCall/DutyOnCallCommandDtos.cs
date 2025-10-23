using MediatR;
using JomarHealthCare.Application.DataModels.Client.DutyOnCall;

namespace JomarHealthCare.Application.CQRS.Client.Commands.DutyOnCall;


public record CreateDutyOnCallCommand(DutyOnCallDataModel DataModel) : IRequest<DutyOnCallDataModel>;
public record UpdateDutyOnCallCommand(DutyOnCallDataModel DataModel) : IRequest<bool>;


public class DeleteDutyOnCallCommand : IRequest<bool>
{
    public int Id { get; set; }
}