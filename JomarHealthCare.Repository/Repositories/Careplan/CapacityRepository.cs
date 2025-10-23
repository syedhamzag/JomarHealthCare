using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class CapacityRepository : GenericRepository<Capacity>, ICapacityRepository
{
    public CapacityRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
