using MediatR;
using JomarHealthCare.Application.DataModels.Territory;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Territories.Queries;


internal class GetByIdTerritoryQueryHander : IRequestHandler<GetTerritoryByIdQuery, TerritoryDataModel>
{
    private readonly ITerritoryRepository _repository;

    public GetByIdTerritoryQueryHander(ITerritoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<TerritoryDataModel> Handle(GetTerritoryByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new TerritoryDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId,
        };
    }
}