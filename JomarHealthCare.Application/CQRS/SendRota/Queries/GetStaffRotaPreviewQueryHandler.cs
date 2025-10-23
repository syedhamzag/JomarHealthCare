using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Application.Repositories.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Queries;


internal class GetByClientBalanceQueryHandler : IRequestHandler<GetStaffRotaPreviewQuery, List<StaffRotaSchedulePreviewDataModel>>
{
    private readonly IStaffRotaRepository _repository;

    public GetByClientBalanceQueryHandler(IStaffRotaRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<StaffRotaSchedulePreviewDataModel>> Handle(GetStaffRotaPreviewQuery request, CancellationToken cancellationToken)
    {
        var entities = _repository.SendRotaPreview(request.data);
        return entities.ToList();
    }
}