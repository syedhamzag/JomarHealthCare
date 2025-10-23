using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientServiceWatchRepository : GenericRepository<ClientServiceWatch>, IClientServiceWatchRepository
{
    public ClientServiceWatchRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
