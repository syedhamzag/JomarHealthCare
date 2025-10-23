using MediatR;
using JomarHealthCare.Application.DataModels.Careplan;
using JomarHealthCare.Application.Repositories.Clients;

namespace JomarHealthCare.Application.CQRS.Careplan.Queries.Balance;

internal class GetByIdBalanceQueryHandler : IRequestHandler<GetByIdBalanceQuery, BalanceDataModel>
{
    private readonly IClientBalanceRepository _repository;

    public GetByIdBalanceQueryHandler(IClientBalanceRepository repository)
    {
        _repository = repository;
    }

    public async Task<BalanceDataModel> Handle(GetByIdBalanceQuery request, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByKeyAsync(request.id, cancellationToken);

        return new BalanceDataModel
        {
            BalanceId = entity.BalanceId,
            Name = entity.Name,
            Description = entity.Description,
            Mobility = entity.Mobility,
            Status = entity.Status,
            ClientId = entity.ClientId,
        };
    }
}

