using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class AreaCodeRepository : GenericRepository<AreaCode>, IAreaCodeRepository
{
    public AreaCodeRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
