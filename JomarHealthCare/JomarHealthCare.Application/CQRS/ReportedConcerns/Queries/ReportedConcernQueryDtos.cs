using MediatR;
using JomarHealthCare.Application.DataModels.ReportedConcerns;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Queries;


public record GetReportedConcernByIdQuery(int id) : IRequest<ReportedConcernDataModel>
{
}
public record GetAllReportedConcernByIdQuery(Guid id) : IRequest<List<ReportedConcernDataModel>>
{
}