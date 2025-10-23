using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class PersonalRepository : GenericRepository<Personal>, IPersonalRepository
{
    public PersonalRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
