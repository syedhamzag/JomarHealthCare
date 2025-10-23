using MediatR;
using JomarHealthCare.Application.DataModels.ReportedConcerns;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Commands;


public record AddReportedConcernCommand(ReportedConcernDataModel DataModel) : IRequest<ReportedConcernDataModel>;
public record DeleteReportedConcernCommand(int ReportedConcernId) : IRequest<bool>;
public record UpdateReportedConcernCommand(ReportedConcernDataModel DataModel) : IRequest<bool>;
