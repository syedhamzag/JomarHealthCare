using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Queries;

internal class GetMedicationLiveTrackerQueryHandler : IRequestHandler<GetLiveMedicationTracker, List<MedTrackerDataModel>>
{
    private readonly IStaffRotaRepository _repository;

    public GetMedicationLiveTrackerQueryHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<MedTrackerDataModel>> Handle(GetLiveMedicationTracker request, CancellationToken cancellationToken)
    {
        var entities = _repository.MedicationLiveTracker(request.data);
        return entities.ToList();
    }
}