using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;

namespace JomarHealthCare.Application.CQRS.Careplan.Commands.Consent;

public record CreateConsentDataCommand(ConsentDataModel DataModel) : IRequest<ConsentDataModel>;
public record UpdateConsentDataCommand(ConsentDataModel DataModel) : IRequest<bool>;