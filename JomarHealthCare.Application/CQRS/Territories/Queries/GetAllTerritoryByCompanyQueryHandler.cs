using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Territory;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Territories.Queries;


internal class GetAllTerritoryByCompanyQueryHandler : IRequestHandler<GetAllTerritoryCompanyIdQuery, List<TerritoryDataModel>>
{
    private readonly ITerritoryRepository _repository;

    public GetAllTerritoryByCompanyQueryHandler(ITerritoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<TerritoryDataModel>> Handle(GetAllTerritoryCompanyIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x =>  x.CompanyId == request.companyId).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new TerritoryDataModel
        {
            Id = entity.Id,
            Name = entity.Name,
            CompanyId = entity.CompanyId
        }).ToList();
    }
}