using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients.Rotering;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients.Rotering;

public class RotaDayOfWeekRepository : GenericRepository<RotaDayofWeek>, IRotaDayOfWeekRepository
{
    public RotaDayOfWeekRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
