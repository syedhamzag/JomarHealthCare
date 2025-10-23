using MediatR;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record DeleteCompanyMessageCommand(int Id) : IRequest<bool>;
}
