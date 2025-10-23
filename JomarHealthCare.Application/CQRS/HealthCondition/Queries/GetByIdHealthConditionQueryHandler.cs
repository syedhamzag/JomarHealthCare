using MediatR;
using JomarHealthCare.Application.DataModels.HealthCondition;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HealthCondition.Queries;

internal class GetByIdHealthConditionQueryHandler : IRequestHandler<GetHealthConditionByIdQuery, HealthConditionModelData>
{
    private readonly IHealthConditionRepository _repository;

    public GetByIdHealthConditionQueryHandler(IHealthConditionRepository repository)
    {
        _repository = repository;
    }

    public async Task<HealthConditionModelData> Handle(GetHealthConditionByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.HCId, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new HealthConditionModelData
        {
            HCId = entity.HCId,
            Name = entity.Name,
            Description = entity.Description,
            Condition = entity.Condition,
            CausesAndTrigger = entity.CausesAndTrigger,
            Symptoms = entity.Symptoms,
            ClientManagingWithCondition = entity.ClientManagingWithCondition,
            RiskToClient = entity.RiskToClient,
            RiskToStaff = entity.RiskToStaff,
            ActionRequiredToStaff = entity.ActionRequiredToStaff,
            EscalationsApproach = entity.EscalationsApproach,
            Image = entity.Image,
            CompanyId = entity.CreatedBy != null ? Guid.Parse(entity.CreatedBy) : null,
        };
    }
}