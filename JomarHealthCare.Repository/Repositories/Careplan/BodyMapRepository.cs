using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class BodyMapRepository : GenericRepository<BodyMap>, IBodyMapRepository
{
    public BodyMapRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
