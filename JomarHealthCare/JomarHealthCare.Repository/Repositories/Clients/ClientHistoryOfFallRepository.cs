using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientHistoryOfFallRepository : GenericRepository<HistoryOfFall>, IClientHistoryOfFallRepository
{
    public ClientHistoryOfFallRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
