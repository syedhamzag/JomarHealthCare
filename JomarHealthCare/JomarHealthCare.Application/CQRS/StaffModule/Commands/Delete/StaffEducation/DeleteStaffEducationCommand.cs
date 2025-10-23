using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{

    public record DeleteStaffEducationCommand(int Id) : IRequest<bool>;
}