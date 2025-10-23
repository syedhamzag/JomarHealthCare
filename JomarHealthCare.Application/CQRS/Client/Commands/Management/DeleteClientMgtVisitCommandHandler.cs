using MediatR;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Commands.Management;

public class DeleteClientMgtVisitCommandHandler : IRequestHandler<DeleteMgtVisitCommand, bool>
{
    private readonly IClientMgtVisitRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteClientMgtVisitCommandHandler(IClientMgtVisitRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteMgtVisitCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.IsDeleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
