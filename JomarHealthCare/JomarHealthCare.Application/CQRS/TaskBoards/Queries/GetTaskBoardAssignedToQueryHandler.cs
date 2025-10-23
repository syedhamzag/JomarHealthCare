using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.TaskBoard;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.TaskBoards.Queries
{
    public class GetTaskBoardAssignedToQueryHandler : IRequestHandler<GetTaskBoardAssignedToQuery, List<ClientTaskBoardDataModel>>
    {
        private readonly IClientTaskBoardRepository _clientTaskBoardRepository;

        public GetTaskBoardAssignedToQueryHandler(IClientTaskBoardRepository clientTaskBoardRepository)
        {
            _clientTaskBoardRepository = clientTaskBoardRepository;
        }

        public async Task<List<ClientTaskBoardDataModel>> Handle(GetTaskBoardAssignedToQuery request, CancellationToken cancellationToken)
        {
            var entities = await _clientTaskBoardRepository.Get().Include(s=>s.AssignedTo).Where(x => x.AssignedTo.Any( assign => assign.StaffPersonalInfoId == request.key)).ToListAsync(); // This method should return all records.
            return entities.Select(s => new ClientTaskBoardDataModel
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
            }).ToList();
        }
    }
}