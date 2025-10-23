using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.OralCares;

public record CreateOralCareCommand(OralCareDataModel DataModel) : IRequest<OralCareDataModel>;
public record UpdateOralCareCommand(OralCareDataModel DataModel) : IRequest<bool>;
