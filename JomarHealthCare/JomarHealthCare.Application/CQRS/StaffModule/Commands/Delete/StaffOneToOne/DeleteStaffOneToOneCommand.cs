using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{

    public record DeleteStaffOneToOneCommand(int Id) : IRequest<bool>;
}