using MediatR;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Territories.Commands;

public class UpdateTerritoryCommandHandler : IRequestHandler<UpdateTerritoryCommand, bool>
{
    private readonly ITerritoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateTerritoryCommandHandler(ITerritoryRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<bool> Handle(UpdateTerritoryCommand request, CancellationToken cancellationToken)
    {
        var data = await _repository.GetByKeyAsync(request.Id, cancellationToken);
        if (data == null) return false;

        data.Name = request.Name;
        _repository.Update(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return true;
    }
}