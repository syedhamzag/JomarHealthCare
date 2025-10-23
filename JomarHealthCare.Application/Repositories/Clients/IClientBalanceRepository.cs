using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories.Clients;

public interface IClientBalanceRepository : IGenericRepository<Balance>
{
    Task DeleteByClientIdAsync(Guid clientId, CancellationToken cancellationToken);
}
