using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.PhysicalAbility;


internal class GetByIdPhysicalAbilityQueryHandler : IRequestHandler<GetByIdPhysicalAbilityQuery, PhysicalAbilityDataModel>
{
    private readonly IClientPhysicalAbilityRepository _repository;

    public GetByIdPhysicalAbilityQueryHandler(IClientPhysicalAbilityRepository repository)
    {
        _repository = repository;
    }

    public async Task<PhysicalAbilityDataModel> Handle(GetByIdPhysicalAbilityQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        return new PhysicalAbilityDataModel
        {
            PhysicalId = entity.PhysicalId,
            Name = entity.Name,
            Description = entity.Description,
            Mobility = entity.Mobility,
            Status = entity.Status,
            ClientId = entity.ClientId,
        };
    }
}
