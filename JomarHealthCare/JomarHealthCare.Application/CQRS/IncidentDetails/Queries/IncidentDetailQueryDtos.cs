using MediatR;
using JomarHealthCare.Application.DataModels.IncidentDetails;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Queries;


public record GetIncidentDetailByIdQuery(int id) : IRequest<IncidentDetailDataModel>
{
}
public record GetAllIncidentDetailByIdQuery(Guid id) : IRequest<List<IncidentDetailDataModel>>
{
}