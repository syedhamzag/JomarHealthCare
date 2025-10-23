using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.PhysicalAbility;

public record CreatePhysicalAbilityCommand(List<PhysicalAbilityDataModel> DataModel) : IRequest<List<PhysicalAbilityDataModel>>;
public record UpdatePhysicalAbilityCommand(PhysicalAbilityDataModel DataModel) : IRequest<bool>;

public class DeletePhysicalAbilityCommand : IRequest<bool>
{
    public int Id { get; set; }
}