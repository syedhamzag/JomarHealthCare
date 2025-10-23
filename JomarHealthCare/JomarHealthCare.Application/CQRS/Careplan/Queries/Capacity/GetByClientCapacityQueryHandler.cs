using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Capacity;

internal class GetByClientCapacityQueryHandler : IRequestHandler<GetByClientCapacityQuery, CapacityDataModel>
{
    private readonly ICapacityRepository _repository;

    public GetByClientCapacityQueryHandler(ICapacityRepository repository)
    {
        _repository = repository;
    }

    public async Task<CapacityDataModel> Handle(GetByClientCapacityQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new CapacityDataModel();
        }
        return new CapacityDataModel
        {
            CapacityId = entity.CapacityId,
            ClientId = entity.ClientId,
            Pointer = entity.Pointer,
            Implication = entity.Implication,
            Indicators = entity.Indicators
        };
    }
}