using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.ClientDailyTask;

public class DeleteClientDailyTaskCommandHandler : IRequestHandler<DeleteClientDailyTaskCommand, bool>
{
    private readonly IClientDailyTaskRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteClientDailyTaskCommandHandler(IClientDailyTaskRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteClientDailyTaskCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.DailyTaskId, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
