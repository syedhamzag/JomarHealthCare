using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.PhysicalAbility;


internal class GetByClientPhysicalAbilityQueryHandler : IRequestHandler<GetByClientPhysicalAbilityQuery, List<PhysicalAbilityDataModel>>
{
    private readonly IClientPhysicalAbilityRepository _repository;

    public GetByClientPhysicalAbilityQueryHandler(IClientPhysicalAbilityRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<PhysicalAbilityDataModel>> Handle(GetByClientPhysicalAbilityQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        return entities.Select(entity => new PhysicalAbilityDataModel
        {
            PhysicalId = entity.PhysicalId,
            Name = entity.Name,
            Description = entity.Description,
            Mobility = entity.Mobility,
            Status = entity.Status,
            ClientId = entity.ClientId,
        }).ToList();
    }
}