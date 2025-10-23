using MediatR;
using JomarHealthCare.Application.DataModels.IncidentType;

namespace JomarHealthCare.Application.CQRS.IncidentTypes.Commands;


public record CreateIncidentTypeCommand(IncidentTypeDataModel DataModel) : IRequest<IncidentTypeDataModel>;
public record UpdateIncidentTypeCommand(IncidentTypeDataModel DataModel) : IRequest<bool>;


public class DeleteIncidentTypeCommand : IRequest<bool>
{
    public int Id { get; set; }
}