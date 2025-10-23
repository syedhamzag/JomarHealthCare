using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Client.HealthCondition;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HealthCondition;
internal class GetAllClientHealthConditionByClientQueryHandler : IRequestHandler<GetAllClientHealthConditionByClientQuery, List<ClientHealthConditionDataModel>>
{
    private readonly IClientHealthConditionRepository _repository;

    public GetAllClientHealthConditionByClientQueryHandler(IClientHealthConditionRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ClientHealthConditionDataModel>> Handle(GetAllClientHealthConditionByClientQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync(); // This method should return all records.

        return entities.Select(entity => new ClientHealthConditionDataModel
        {
            CHCId = entity.CHCId,
            Description = entity.Description,
            Name = entity.Name,
            Condition = entity.Condition,
            CausesAndTrigger = entity.CausesAndTrigger,
            Symptoms = entity.Symptoms,
            ClientManagingWithCondition = entity.ClientManagingWithCondition,
            ClientId = entity.ClientId,
            RiskToClient = entity.RiskToClient,
            RiskToStaff = entity.RiskToStaff,
            ActionRequiredToStaff = entity.ActionRequiredToStaff,
            EscalationsApproach = entity.EscalationsApproach,
            Image = entity.Image
        }).ToList();
    }
}