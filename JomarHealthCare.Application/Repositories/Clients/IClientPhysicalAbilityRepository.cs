using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories.Clients;

public interface IClientPhysicalAbilityRepository : IGenericRepository<PhysicalAbility>
{
    Task DeleteByClientIdAsync(Guid clientId, CancellationToken cancellationToken);
}
