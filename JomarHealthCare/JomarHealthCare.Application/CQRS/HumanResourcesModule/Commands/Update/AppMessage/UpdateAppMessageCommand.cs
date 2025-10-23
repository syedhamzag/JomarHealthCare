using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule.AppMessage;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record UpdateAppMessageCommand(AppMessageDataModel DataModel) : IRequest<bool>;
}
