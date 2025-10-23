using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients.Rotering;

public class RotaTaskRepository : GenericRepository<RotaTask>, IRotaTaskRepository
{
    public RotaTaskRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
