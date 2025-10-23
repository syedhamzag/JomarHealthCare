using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Queries;


internal class GetLiveTrackerConcernQueryHandler : IRequestHandler<GetLiveTrackerConcern, List<LiveTracker>>
{
    private readonly IStaffRotaRepository _repository;

    public GetLiveTrackerConcernQueryHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<LiveTracker>> Handle(GetLiveTrackerConcern request, CancellationToken cancellationToken)
    {
        var entities = _repository.LiveTrackerByConcern(request.data);
        return entities.ToList();
    }
}