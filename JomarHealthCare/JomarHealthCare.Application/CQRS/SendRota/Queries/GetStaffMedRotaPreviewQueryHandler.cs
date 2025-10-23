using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Queries;


internal class GetStaffMedRotaPreviewQueryHandler : IRequestHandler<GetStaffMedRotaPreviewQuery, List<MedTrackerDataModel>>
{
    private readonly IStaffRotaRepository _repository;

    public GetStaffMedRotaPreviewQueryHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<MedTrackerDataModel>> Handle(GetStaffMedRotaPreviewQuery request, CancellationToken cancellationToken)
    {
        var entities = _repository.SendRotaMedicationPreview(request.data);
        return entities.ToList();
    }
}