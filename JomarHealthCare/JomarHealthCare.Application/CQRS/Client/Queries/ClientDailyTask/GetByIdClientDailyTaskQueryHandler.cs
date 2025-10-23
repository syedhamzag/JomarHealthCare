using MediatR;
using JomarHealthCare.Application.DataModels.ClientDailyTask;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.ClientDailyTask;
internal class GetByIdClientDailyTaskQueryHandler : IRequestHandler<GetClientDailyTaskByIdQuery, ClientDailyTaskModelData>
{
    private readonly IClientDailyTaskRepository _repository;

    public GetByIdClientDailyTaskQueryHandler(IClientDailyTaskRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientDailyTaskModelData> Handle(GetClientDailyTaskByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ClientDailyTaskModelData
        {
            DailyTaskId = entity.DailyTaskId,
            DailyTaskName = entity.DailyTaskName,
            Date = entity.Date,
            AmendmentDate = entity.AmendmentDate,
            ClientId = entity.ClientId,
            HowToPerformTask = entity.HowToPerformTask,
            Image = entity.Image,
            Video = entity.Video
        };
    }
}