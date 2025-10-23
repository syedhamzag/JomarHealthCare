using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientInvolvingPartyRepository : GenericRepository<ClientInvolvingParty>, IClientInvolvingPartyRepository
{
    public ClientInvolvingPartyRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
