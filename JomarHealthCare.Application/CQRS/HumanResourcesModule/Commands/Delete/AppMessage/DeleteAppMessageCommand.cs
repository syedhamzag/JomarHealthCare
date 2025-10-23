using MediatR;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record DeleteAppMessageCommand(int Id) : IRequest<bool>;
}
