using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Territories.Commands;

public class DeleteTerritoryCommandHandler : IRequestHandler<DeleteTerritoryCommand, bool>
{
    private readonly ITerritoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public DeleteTerritoryCommandHandler(ITerritoryRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(DeleteTerritoryCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;
        _repository.Delete(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}
