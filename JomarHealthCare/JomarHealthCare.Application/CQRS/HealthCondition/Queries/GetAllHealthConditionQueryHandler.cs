using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.HealthCondition;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.HealthCondition.Queries;
internal class GetAllHealthConditionQueryHandler : IRequestHandler<GetAllHealthConditionQuery, List<HealthConditionModelData>>
{
    private readonly IHealthConditionRepository _repository;

    public GetAllHealthConditionQueryHandler(IHealthConditionRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<HealthConditionModelData>> Handle(GetAllHealthConditionQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().ToListAsync(); // This method should return all records.

        return entities.Select(entity => new HealthConditionModelData
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
        }).ToList();
    }
}
