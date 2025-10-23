using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class OralCareRepository : GenericRepository<OralCare>, IOralCareRepository
{
    public OralCareRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
