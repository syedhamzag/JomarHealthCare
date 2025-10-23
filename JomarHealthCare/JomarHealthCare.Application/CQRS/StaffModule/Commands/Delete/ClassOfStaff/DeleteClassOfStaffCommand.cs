using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteClassOfStaffCommand(int Id) : IRequest<bool>;
}