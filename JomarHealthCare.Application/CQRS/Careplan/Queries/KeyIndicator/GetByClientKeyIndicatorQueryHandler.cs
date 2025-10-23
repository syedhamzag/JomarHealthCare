using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.CarePlan;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.KeyIndicator;


internal class GetByClientKeyIndicatorQueryHandler : IRequestHandler<GetByClientKeyIndicatorQuery, KeyIndicatorDataModel>
{
    private readonly IKeyIndicatorRepository _repository;

    public GetByClientKeyIndicatorQueryHandler(IKeyIndicatorRepository repository)
    {
        _repository = repository;
    }

    public async Task<KeyIndicatorDataModel> Handle(GetByClientKeyIndicatorQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.Get().Where(x => x.ClientId == request.clientId).FirstOrDefaultAsync();
        if (entity == null)
        {
            return new KeyIndicatorDataModel();
        }
        return new KeyIndicatorDataModel
        {
            KeyId = entity.KeyId,
            AboutMe = entity.AboutMe,
            FamilyRole = entity.FamilyRole,
            LivingStatus = entity.LivingStatus,
            Debture = entity.Debture,
            ThingsILike = entity.ThingsILike,
            LogMethod = entity.LogMethod,
            ClientId = entity.ClientId,
        };
    }
}