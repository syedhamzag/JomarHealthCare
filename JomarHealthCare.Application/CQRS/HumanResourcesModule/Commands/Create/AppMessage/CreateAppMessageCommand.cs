using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.AppMessage;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record CreateAppMessageCommand(AppMessageDataModel DataModel) : IRequest<AppMessageDataModel>;
}
