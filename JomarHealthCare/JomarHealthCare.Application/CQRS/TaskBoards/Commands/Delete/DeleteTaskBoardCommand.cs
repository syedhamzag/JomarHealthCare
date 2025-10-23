using MediatR;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Commands
{
    public record DeleteTaskBoardCommand(int TaskID) : IRequest<bool>;




}