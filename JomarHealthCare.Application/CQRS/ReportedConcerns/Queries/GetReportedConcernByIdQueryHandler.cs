using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ReportedConcerns;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Queries;

internal class GetReportedConcernByIdQueryHandler : IRequestHandler<GetReportedConcernByIdQuery, ReportedConcernDataModel>
{
    private readonly IReportedConcernRepository _repository;

    public GetReportedConcernByIdQueryHandler(IReportedConcernRepository repository)
    {
        _repository = repository;
    }

    public async Task<ReportedConcernDataModel> Handle(GetReportedConcernByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ReportedConcernId == request.id).FirstOrDefaultAsync(cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ReportedConcernDataModel
        {
            ReportedConcernId = entity.ReportedConcernId,
            ReportedConcernType = entity.ReportedConcernType,
            CompanyId = entity.CompanyId,
        };
    }
}