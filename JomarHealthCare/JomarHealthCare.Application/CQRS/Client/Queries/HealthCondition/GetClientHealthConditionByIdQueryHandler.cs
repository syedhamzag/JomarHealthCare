using MediatR;
using JomarHealthCare.Application.DataModels.Client.HealthCondition;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Client.Queries.HealthCondition;
internal class GetClientHealthConditionByIdQueryHandler : IRequestHandler<GetClientHealthConditionByIdQuery, ClientHealthConditionDataModel>
{
    private readonly IClientHealthConditionRepository _repository;

    public GetClientHealthConditionByIdQueryHandler(IClientHealthConditionRepository repository)
    {
        _repository = repository;
    }

    public async Task<ClientHealthConditionDataModel> Handle(GetClientHealthConditionByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException("Not found");
        }
        return new ClientHealthConditionDataModel
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
        };
    }
}