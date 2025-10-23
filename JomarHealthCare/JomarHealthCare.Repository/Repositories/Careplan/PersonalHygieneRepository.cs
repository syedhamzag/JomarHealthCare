using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class PersonalHygieneRepository : GenericRepository<PersonalHygiene>, IPersonalHygieneRepository
{
    public PersonalHygieneRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
