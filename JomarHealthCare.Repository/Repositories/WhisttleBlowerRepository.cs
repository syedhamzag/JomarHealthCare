using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class WhisttleBlowerRepository : GenericRepository<WhisttleBlower>, IWhisttleBlowerRepository
{
    public WhisttleBlowerRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}