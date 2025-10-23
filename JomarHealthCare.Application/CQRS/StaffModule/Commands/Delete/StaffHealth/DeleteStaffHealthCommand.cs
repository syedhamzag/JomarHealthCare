using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffHealthCommand(int Id) : IRequest<bool>;
}