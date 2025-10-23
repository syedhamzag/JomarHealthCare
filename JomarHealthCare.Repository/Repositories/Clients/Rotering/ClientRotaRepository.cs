using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients.Rotering;

public class ClientRotaRepository : GenericRepository<ClientRota>, IClientRotaRepository
{
    public ClientRotaRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
