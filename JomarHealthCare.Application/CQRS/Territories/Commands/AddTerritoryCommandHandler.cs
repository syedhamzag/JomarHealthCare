using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Territories.Commands;

public class AddTerritoryCommandHandler : IRequestHandler<AddTerritoryCommand, Territory>
{
    private readonly ITerritoryRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    public AddTerritoryCommandHandler(ITerritoryRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task<Territory> Handle(AddTerritoryCommand request, CancellationToken cancellationToken)
    {
        var data = new Territory
        {
            Name = request.Name,
            CompanyId = request.CompanyId
        };

        await _repository.AddAsync(data);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return data;
    }
}