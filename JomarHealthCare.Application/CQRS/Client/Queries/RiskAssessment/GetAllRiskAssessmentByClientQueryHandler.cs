using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.RiskAssessment;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.RiskAssessment;

internal class GetAllRiskAssessmentByClientQueryHandler : IRequestHandler<GetAllHomeRiskAssessmentByClientQuery, List<HomeRiskAssessmentDataModel>>
{
    private readonly IHomeRiskAssessmentRepository _repository;

    public GetAllRiskAssessmentByClientQueryHandler(IHomeRiskAssessmentRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<HomeRiskAssessmentDataModel>> Handle(GetAllHomeRiskAssessmentByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).Include(x => x.HomeRiskAssessmentTask).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new HomeRiskAssessmentDataModel
        {
            HeadingId = entity.HeadingId,
            HomeRiskAssessmentId = entity.HomeRiskAssessmentId,
            ClientId = entity.ClientId,
            HomeRiskAssessmentTask = entities.SelectMany(x => x.HomeRiskAssessmentTask).Select(task => new HomeRiskAssessmentDataItemModel
            {
                HomeRiskAssessmentTaskId = task.HomeRiskAssessmentTaskId,
                HomeRiskAssessmentId = task.HomeRiskAssessmentId,
                Title = task.Title,
                Answer = task.Answer,
                Comment = task.Comment
            }).ToList()
        }).ToList();
    }
}