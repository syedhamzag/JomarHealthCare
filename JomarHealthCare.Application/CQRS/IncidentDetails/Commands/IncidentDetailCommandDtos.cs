using MediatR;
using JomarHealthCare.Application.DataModels.IncidentDetails;

namespace JomarHealthCare.Application.CQRS.IncidentDetails.Commands;


public record AddIncidentDetailCommand(IncidentDetailDataModel DataModel) : IRequest<IncidentDetailDataModel>;
public record DeleteIncidentDetailCommand(int IncidentDetailId) : IRequest<bool>;
public record UpdateIncidentDetailCommand(IncidentDetailDataModel DataModel) : IRequest<bool>;
