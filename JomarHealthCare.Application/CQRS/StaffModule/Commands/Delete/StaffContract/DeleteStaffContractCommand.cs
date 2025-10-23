using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteStaffContractCommand(int Id) : IRequest<bool>;
}