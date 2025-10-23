using MediatR;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Queries
{
    public class TaskBoardQuery : IRequest<IQueryable<ClientTaskBoardDataModel>>
    {
        public string Id { get; set; } = string.Empty;
    }
    public record GetTaskBoardByCompanyIdQuery(Guid key) : IRequest<List<ClientTaskBoardDataModel>>;
    public record GetTaskBoardAssignedToQuery(Guid key) : IRequest<List<ClientTaskBoardDataModel>>;
}