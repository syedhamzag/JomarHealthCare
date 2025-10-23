using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffCompetenceTestCommand(int Id) : IRequest<bool>;
}