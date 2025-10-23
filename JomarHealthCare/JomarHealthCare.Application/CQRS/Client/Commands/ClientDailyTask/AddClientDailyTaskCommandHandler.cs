using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientDailyTask;
public class AddClientDailyTaskCommandHandler : IRequestHandler<AddClientDailyTaskCommand, Domain.Entities.ClientDailyTask>
{
    private readonly IClientDailyTaskRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddClientDailyTaskCommandHandler(IClientDailyTaskRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Domain.Entities.ClientDailyTask> Handle(AddClientDailyTaskCommand request, CancellationToken cancellationToken)
    {
        var data = new Domain.Entities.ClientDailyTask
        {
            DailyTaskName = request.DailyTaskName,
            Date = request.Date,
            AmendmentDate = request.AmendmentDate,
            ClientId = request.ClientId,
            HowToPerformTask = request.HowToPerformTask,
            Image = request.Image,
            Video = request.Video
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}