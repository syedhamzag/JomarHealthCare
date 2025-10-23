using MediatR;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;

namespace JomarHealthCare.Application.CQRS.Client.Commands.RiskAssessment;


public record CreateRiskAssessmentCommand(HomeRiskAssessmentDataModel DataModel) : IRequest<HomeRiskAssessmentDataModel>;
public record UpdateRiskAssessmentCommand(HomeRiskAssessmentDataModel DataModel) : IRequest<bool>;