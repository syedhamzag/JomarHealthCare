using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Reviews;

internal class GetByClientReviewQueryHandler : IRequestHandler<GetByClientReviewQuery, ReviewDataModel>
{
    private readonly IReviewRepository _repository;

    public GetByClientReviewQueryHandler(IReviewRepository repository)
    {
        _repository = repository;
    }

    public async Task<ReviewDataModel> Handle(GetByClientReviewQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if(entity == null)
        {
            return new ReviewDataModel();
        }

        return new ReviewDataModel
        {
            ReviewId = entity.ReviewId,
            CP_PreDate = entity.CP_PreDate,
            CP_ReviewDate = entity.CP_ReviewDate,
            CarePlanStatus = entity.CarePlanStatus,
            RA_PreDate = entity.RA_PreDate,
            RA_ReviewDate = entity.RA_ReviewDate,
            RisAssistmentStatus = entity.RisAssistmentStatus,
            ClientId = entity.ClientId,
        };
    }
}