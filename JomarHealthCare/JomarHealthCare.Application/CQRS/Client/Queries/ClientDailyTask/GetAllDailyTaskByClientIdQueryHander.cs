using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ClientDailyTask;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ClientDailyTask;

internal class GetAllDailyTaskByClientIdQueryHander : IRequestHandler<GetAllDailyTaskByClientIdQuery, List<ClientDailyTaskModelData>>
{
    private readonly IClientDailyTaskRepository _repository;

    public GetAllDailyTaskByClientIdQueryHander(IClientDailyTaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientDailyTaskModelData>> Handle(GetAllDailyTaskByClientIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ClientDailyTaskModelData
        {
            DailyTaskId = entity.DailyTaskId,
            DailyTaskName = entity.DailyTaskName,
            Date = entity.Date,
            AmendmentDate = entity.AmendmentDate,
            ClientId = entity.ClientId,
            HowToPerformTask = entity.HowToPerformTask,
            Image = entity.Image,
            Video = entity.Video
        }).ToList();
    }
}




