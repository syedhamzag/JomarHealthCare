using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients.Rotering;

public class RotaRepository : GenericRepository<Rota>, IRotaRepository
{
    public RotaRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
