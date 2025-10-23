using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientMgtVisitRepository : GenericRepository<ClientMgtVisit>, IClientMgtVisitRepository
{
    public ClientMgtVisitRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
