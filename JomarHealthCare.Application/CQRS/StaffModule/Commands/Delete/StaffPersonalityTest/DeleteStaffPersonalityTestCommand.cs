using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffPersonalityTestCommand(int Id) : IRequest<bool>;
}