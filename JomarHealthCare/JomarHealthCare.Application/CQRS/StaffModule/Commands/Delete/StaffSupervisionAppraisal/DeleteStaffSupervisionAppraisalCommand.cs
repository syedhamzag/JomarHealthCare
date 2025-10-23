using MediatR;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public record DeleteStaffSupervisionAppraisalCommand(int Id) : IRequest<bool>;
}
