using MediatR;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record DeleteInterviewQuestionCommand(int Id) : IRequest<bool>;

}
