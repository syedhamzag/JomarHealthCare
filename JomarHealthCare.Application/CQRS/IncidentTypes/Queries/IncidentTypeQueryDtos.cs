using MediatR;
using JomarHealthCare.Application.DataModels.IncidentType;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Queries;

public record GetAllIncidentTypeQuery() : IRequest<List<IncidentTypeDataModel>>;

public record GetAllByCompanyIdIncidentTypeQuery(Guid companyId) : IRequest<List<IncidentTypeDataModel>>;


public record GetByIdIncidentTypeQuery(int id) : IRequest<IncidentTypeDataModel>;