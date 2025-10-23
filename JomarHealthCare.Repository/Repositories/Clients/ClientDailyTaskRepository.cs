using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientDailyTaskRepository : GenericRepository<ClientDailyTask>, IClientDailyTaskRepository
{
    public ClientDailyTaskRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}