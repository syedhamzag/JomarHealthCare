using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.HistoryFall;

internal class GetByClientHistoryOfFallQueryHandler : IRequestHandler<GetByClientHistoryOfFallQuery, HistoryOfFallDataModel>
{
    private readonly IClientHistoryOfFallRepository _repository;

    public GetByClientHistoryOfFallQueryHandler(IClientHistoryOfFallRepository repository)
    {
        _repository = repository;
    }

    public async Task<HistoryOfFallDataModel> Handle(GetByClientHistoryOfFallQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new HistoryOfFallDataModel();
        }
        return new HistoryOfFallDataModel
        {
            HistoryId = entity.HistoryId,
            Details = entity.Details,
            Date = entity.Date,
            Cause = entity.Cause,
            Prevention = entity.Prevention,
            IsFallOfRisk = entity.IsFallOfRisk,
            DetailofRisk = entity.DetailofRisk,
            CauseAndTriger = entity.CauseAndTriger,
            HowToControl = entity.HowToControl,
            UserAwareOfFall = entity.UserAwareOfFall,
            Escallation = entity.Escallation,
            ClientId = entity.ClientId,
        };
    }
}
