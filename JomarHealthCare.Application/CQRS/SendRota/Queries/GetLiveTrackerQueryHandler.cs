using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Queries;


internal class GetLiveTrackerQueryHandler : IRequestHandler<GetLiveTracker, List<LiveTracker>>
{
    private readonly IStaffRotaRepository _repository;

    public GetLiveTrackerQueryHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<LiveTracker>> Handle(GetLiveTracker request, CancellationToken cancellationToken)
    {
        var entities = _repository.LiveTracker(request.data);
        return entities.ToList();
    }
}