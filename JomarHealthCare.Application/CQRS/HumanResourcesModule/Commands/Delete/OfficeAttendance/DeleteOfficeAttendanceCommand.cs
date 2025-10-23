using MediatR;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record DeleteOfficeAttendanceCommand(int Id) : IRequest<bool>;
}
