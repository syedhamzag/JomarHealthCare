using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class KeyIndicatorRepository : GenericRepository<KeyIndicators>, IKeyIndicatorRepository
{
    public KeyIndicatorRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
