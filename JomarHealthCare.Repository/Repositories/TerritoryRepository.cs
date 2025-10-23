using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class TerritoryRepository : GenericRepository<Territory>, ITerritoryRepository
{
    public TerritoryRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
