using MediatR;
using JomarHealthCare.Application.DataModels.Territory;

namespace JomarHealthCare.Application.CQRS.Territories.Queries;

public record GetTerritoryByIdQuery(int id) : IRequest<TerritoryDataModel>;

public record GetAllTerritoryQuery() : IRequest<List<TerritoryDataModel>>;

public record GetAllTerritoryCompanyIdQuery(Guid companyId) : IRequest<List<TerritoryDataModel>>;
