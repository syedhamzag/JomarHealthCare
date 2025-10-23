using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.PhysicalAbility;


public class DeletePhysicalAbilityCommandHandler : IRequestHandler<DeletePhysicalAbilityCommand, bool>
{
    private readonly IClientPhysicalAbilityRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeletePhysicalAbilityCommandHandler(IClientPhysicalAbilityRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeletePhysicalAbilityCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}