using MediatR;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Commands
{
    public record CreateTaskBoardCommand(ClientTaskBoardDataModel DataModel) : IRequest<ClientTaskBoardDataModel>;
}