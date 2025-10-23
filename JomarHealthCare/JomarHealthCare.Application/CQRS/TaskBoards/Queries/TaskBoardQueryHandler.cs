using MediatR;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Queries
{
    public class TaskBoardQueryHandler : IRequestHandler<TaskBoardQuery, IQueryable<ClientTaskBoardDataModel>>
    {
        private readonly IClientTaskBoardRepository _userRepository;

        public TaskBoardQueryHandler(IClientTaskBoardRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IQueryable<ClientTaskBoardDataModel>> Handle(TaskBoardQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _userRepository.Get(x => x.ClientId.ToString().Trim() == key.ToString().Trim()).Select(s => new ClientTaskBoardDataModel
                {
                    ClientId = s.ClientId.ToString(),
                    Attachment = s.Attachment,
                    CompletionDate = s.CompletionDate,
                    Note = s.Note,
                    Priority = s.Priority,
                    Status = s.Status,
                    TaskBoardId = s.TaskBoardId,
                    TaskImage = s.TaskImage,
                    TaskName = s.TaskName,
                    Type = s.Type,
                    CreatedBy = s.CreatedBy.ToString(),
                    AssignedTo = s.AssignedTo.Select(task => new ClientTaskBoardAssignedToDataModel
                    {
                        StaffPersonalInfoId = task.StaffPersonalInfoId,
                        TaskBoardId = task.TaskBoardId,
                        TaskBoardAssignedToId = task.TaskBoardAssignedToId
                    }).ToList()
                });
            }
            return _userRepository.Get().Select(s => new ClientTaskBoardDataModel
            {
                ClientId = s.ClientId.ToString(),
                Attachment = s.Attachment,
                CompletionDate = s.CompletionDate,
                Note = s.Note,
                Priority = s.Priority,
                Status = s.Status,
                TaskBoardId = s.TaskBoardId,
                TaskImage = s.TaskImage,
                TaskName = s.TaskName,
                Type = s.Type,
                CreatedBy = s.CreatedBy.ToString(),
                AssignedTo = s.AssignedTo.Select(task => new ClientTaskBoardAssignedToDataModel
                {
                    StaffPersonalInfoId = task.StaffPersonalInfoId,
                    TaskBoardId = task.TaskBoardId,
                    TaskBoardAssignedToId = task.TaskBoardAssignedToId
                }).ToList()
            });
        }
    }
}