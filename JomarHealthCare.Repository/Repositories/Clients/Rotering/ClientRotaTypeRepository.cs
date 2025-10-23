using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients.Rotering;

public class ClientRotaTypeRepository : GenericRepository<ClientRotaType>, IClientRotaTypeRepository
{
    public ClientRotaTypeRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
