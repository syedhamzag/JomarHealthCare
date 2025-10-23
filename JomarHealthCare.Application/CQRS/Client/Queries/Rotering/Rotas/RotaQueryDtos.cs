using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.Rotas;

public record GetAllByCompanyRotaQuery(Guid companyId) : IRequest<List<RotaDataModel>>;


public record GetByIdRotaQuery(int id) : IRequest<RotaDataModel>;