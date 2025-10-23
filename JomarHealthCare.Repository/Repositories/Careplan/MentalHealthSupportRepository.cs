using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class MentalHealthSupportRepository : GenericRepository<MentalHealthSupport>, IMentalHealthSupportRepository
{
    public MentalHealthSupportRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
