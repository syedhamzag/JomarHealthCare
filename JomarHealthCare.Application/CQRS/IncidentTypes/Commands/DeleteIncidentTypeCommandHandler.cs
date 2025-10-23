using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Commands;

public class DeleteIncidentTypeCommandHandler : IRequestHandler<DeleteIncidentTypeCommand, bool>
{
    private readonly IIncidentTypeRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteIncidentTypeCommandHandler(IIncidentTypeRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteIncidentTypeCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        data.Deleted = true; // Soft delete
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}