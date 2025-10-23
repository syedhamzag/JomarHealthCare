using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

internal class ClientPetRepository : GenericRepository<Pets>, IClientPetRepository
{
    public ClientPetRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}