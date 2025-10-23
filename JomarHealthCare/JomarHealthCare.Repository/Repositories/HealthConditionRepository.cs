using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class HealthConditionRepository : GenericRepository<HealthCondition>, IHealthConditionRepository
{
    public HealthConditionRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
