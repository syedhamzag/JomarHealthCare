using MediatR;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.BodyMap;

public class DeleteBodyMapCommandHandler : IRequestHandler<DeleteBodyMapCommand, bool>
{
    private readonly IBodyMapRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteBodyMapCommandHandler(IBodyMapRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteBodyMapCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}