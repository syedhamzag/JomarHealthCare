using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffInfectionControlCommand(int Id) : IRequest<bool>;
}