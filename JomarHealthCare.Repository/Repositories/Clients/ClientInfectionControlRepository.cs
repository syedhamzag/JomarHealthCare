using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientInfectionControlRepository : GenericRepository<InfectionControl>, IClientInfectionControlRepository
{
    public ClientInfectionControlRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
