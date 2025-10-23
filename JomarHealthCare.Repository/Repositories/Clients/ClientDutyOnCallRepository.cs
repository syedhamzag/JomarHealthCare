using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientDutyOnCallRepository : GenericRepository<DutyOnCall>, IClientDutyOnCallRepository
{
    public ClientDutyOnCallRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
