using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

internal class ClientHealthConditionRepository : GenericRepository<ClientHealthCondition>, IClientHealthConditionRepository
{
    public ClientHealthConditionRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}

