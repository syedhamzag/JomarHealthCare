using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories.CarePlan;

public interface IPersonCentredRepository : IGenericRepository<PersonCentred>
{
    Task DeleteByClientIdAsync(Guid clientId, CancellationToken cancellationToken);
}
