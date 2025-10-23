using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaType;

public record GetAllRotaTypeQuery() : IRequest<List<ClientRotaTypeDataModel>>;

public record GetAllByCompanyIdRotaTypeQuery(Guid companyId) : IRequest<List<ClientRotaTypeDataModel>>;


public record GetByIdRotaTypeQuery(int id) : IRequest<ClientRotaTypeDataModel>;