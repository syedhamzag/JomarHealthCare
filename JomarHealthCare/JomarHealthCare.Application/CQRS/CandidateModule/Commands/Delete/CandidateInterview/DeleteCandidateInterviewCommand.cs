using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteCandidateInterviewCommand(int Id) : IRequest<bool>;
}
