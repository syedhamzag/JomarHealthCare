using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffWorkTeamCommand(int Id) : IRequest<bool>;
}