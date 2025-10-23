using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HealthCondition.Commands;

public class DeleteHealthConditionCommandHandler : IRequestHandler<DeleteHealthConditionCommand, bool>
{
    private readonly IHealthConditionRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteHealthConditionCommandHandler(IHealthConditionRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteHealthConditionCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.HCId, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
