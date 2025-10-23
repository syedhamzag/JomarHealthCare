using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffInterviewCommand(int Id) : IRequest<bool>;
}