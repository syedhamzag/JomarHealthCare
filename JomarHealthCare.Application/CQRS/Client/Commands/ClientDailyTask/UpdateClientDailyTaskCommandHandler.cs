using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientDailyTask;


public class UpdateClientDailyTaskCommandHandler : IRequestHandler<UpdateClientDailyTaskCommand, bool>
{
    private readonly IClientDailyTaskRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateClientDailyTaskCommandHandler(IClientDailyTaskRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateClientDailyTaskCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.DailyTaskId, cancellationToken);
        if (data == null) return false;

        data.DailyTaskName = request.DailyTaskName;
        data.Date = request.Date;
        data.AmendmentDate = request.AmendmentDate;
        data.HowToPerformTask = request.HowToPerformTask;
        data.Image = request.Image;
        data.Video = request.Video;

        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}