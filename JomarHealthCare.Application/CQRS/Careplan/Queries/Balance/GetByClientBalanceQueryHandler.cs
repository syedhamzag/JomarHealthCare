using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Balance;

internal class GetByClientBalanceQueryHandler : IRequestHandler<GetByClientBalanceQuery, List<BalanceDataModel>>
{
    private readonly IClientBalanceRepository _repository;

    public GetByClientBalanceQueryHandler(IClientBalanceRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BalanceDataModel>> Handle(GetByClientBalanceQuery request, CancellationToken cancellationToken)
    {
        var entities = await _repository.Get().Where(x => x.ClientId == request.clientId && !x.IsDeleted).ToListAsync();

        return entities.Select(entity => new BalanceDataModel
        {
            BalanceId = entity.BalanceId,
            Name = entity.Name,
            Description = entity.Description,
            Mobility = entity.Mobility,
            Status = entity.Status,
            ClientId = entity.ClientId,
        }).ToList();
    }
}