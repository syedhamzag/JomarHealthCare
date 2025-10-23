using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffShadowingCommand(int Id) : IRequest<bool>;
}