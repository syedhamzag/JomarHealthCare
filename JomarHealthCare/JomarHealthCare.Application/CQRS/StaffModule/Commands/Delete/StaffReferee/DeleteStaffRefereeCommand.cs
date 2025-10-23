using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffRefereeCommand(int Id) : IRequest<bool>;
}