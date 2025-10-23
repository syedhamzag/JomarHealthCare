using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{

    public record DeleteStaffKeyWorkerVoiceCommand(int Id) : IRequest<bool>;
}