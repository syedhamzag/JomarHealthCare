using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientHealthAndLivingRepository : GenericRepository<HealthAndLiving>, IClientHealthAndLivingRepository
{
    public ClientHealthAndLivingRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
