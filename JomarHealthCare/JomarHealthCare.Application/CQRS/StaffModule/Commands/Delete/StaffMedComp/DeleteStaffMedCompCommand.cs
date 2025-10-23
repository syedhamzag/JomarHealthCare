using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{

    public record DeleteStaffMedCompCommand(int Id) : IRequest<bool>;
}