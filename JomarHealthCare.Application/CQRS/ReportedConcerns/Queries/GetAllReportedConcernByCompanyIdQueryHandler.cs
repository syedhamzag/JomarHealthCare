using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.ReportedConcerns;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.ReportedConcerns.Queries;


internal class GetAllReportedConcernByCompanyIdQueryHandler : IRequestHandler<GetAllReportedConcernByIdQuery, List<ReportedConcernDataModel>>
{
    private readonly IReportedConcernRepository _repository;

    public GetAllReportedConcernByCompanyIdQueryHandler(IReportedConcernRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ReportedConcernDataModel>> Handle(GetAllReportedConcernByIdQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.CompanyId == request.id).ToListAsync(cancellationToken); // This method should return all records.

        return entities.Select(entity => new ReportedConcernDataModel
        {
            ReportedConcernId = entity.ReportedConcernId,
            ReportedConcernType = entity.ReportedConcernType,
            CompanyId = entity.CompanyId,
        }).ToList();
    }
}