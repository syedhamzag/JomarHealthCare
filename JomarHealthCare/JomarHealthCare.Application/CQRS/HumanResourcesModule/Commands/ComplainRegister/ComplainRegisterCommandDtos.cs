using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.Complaints;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Commands.ComplainRegister;

public record CreateComplainRegisterCommand(ComplainRegistorDataModel DataModel) : IRequest<ComplainRegistorDataModel>;
public record UpdateComplainRegisterCommand(ComplainRegistorDataModel DataModel) : IRequest<bool>;

public class DeleteComplainRegisterCommand : IRequest<bool>
{
    public int Id { get; set; }
}
