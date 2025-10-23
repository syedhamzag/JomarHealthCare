using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Policy.Commands;

public class DeletePolicyCommandHandler : IRequestHandler<DeletePolicyCommand, bool>
{
    private readonly IPolicyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeletePolicyCommandHandler(IPolicyRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeletePolicyCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.PolicyId, cancellationToken);
        if (data == null) return false;

        data.IsDeleted = true;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}