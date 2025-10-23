using MediatR;
using JomarHealthCare.Application.Repositories.Clients.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Rotering.RotaTasks;

public class DeleteRotaTaskCommandHandler : IRequestHandler<DeleteRotaTaskCommand, bool>
{
    private readonly IRotaTaskRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteRotaTaskCommandHandler(IRotaTaskRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteRotaTaskCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.Deleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
