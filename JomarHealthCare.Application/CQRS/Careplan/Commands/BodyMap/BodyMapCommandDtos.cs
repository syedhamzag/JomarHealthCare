using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.BodyMap;
public record CreateBodyMapCommand(BodyMapDataModel DataModel) : IRequest<BodyMapDataModel>;
public record UpdateBodyMapCommand(BodyMapDataModel DataModel) : IRequest<bool>;

public class DeleteBodyMapCommand : IRequest<bool>
{
    public int Id { get; set; }
}