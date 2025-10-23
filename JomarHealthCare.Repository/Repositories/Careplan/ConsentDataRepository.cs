using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class ConsentDataRepository : GenericRepository<ConsentData>, IConsentDataRepository
{
    public ConsentDataRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
