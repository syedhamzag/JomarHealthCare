using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.HealthCondition;


public class DeleteClientHealthConditionCommandHandler : IRequestHandler<DeleteClientHealthConditionCommand, bool>
{
    private readonly IClientHealthConditionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteClientHealthConditionCommandHandler(IClientHealthConditionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteClientHealthConditionCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
