using MediatR;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;

namespace JomarHealthCare.Application.CQRS.Client.Queries.RiskAssessment;


public record GetAllHomeRiskAssessmentByClientQuery(Guid clientId) : IRequest<List<HomeRiskAssessmentDataModel>>;