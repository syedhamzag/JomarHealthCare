using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffTrainingCommand(int Id) : IRequest<bool>;
}