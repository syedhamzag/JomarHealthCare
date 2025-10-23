using MediatR;
using JomarHealthCare.Application.DataModels.Client.Rotering;

namespace JomarHealthCare.Application.CQRS.Client.Queries.Rotering.RotaTasks;

public record GetAllRotaTaskQuery() : IRequest<List<RotaTaskDataModel>>;

public record GetAllByCompanyIdRotaTaskQuery(Guid companyId) : IRequest<List<RotaTaskDataModel>>;


public record GetByIdRotaTaskQuery(int id) : IRequest<RotaTaskDataModel>;
