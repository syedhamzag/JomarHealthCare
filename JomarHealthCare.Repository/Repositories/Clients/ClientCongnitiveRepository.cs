using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientCongnitiveRepository : GenericRepository<ClientCongnitive>, IClientCongnitiveRepository
{
    public ClientCongnitiveRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
