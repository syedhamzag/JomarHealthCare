using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class KeyworkerRepository : GenericRepository<ClientKeyworkerNotes>, IKeyworkerRepository
{
    public KeyworkerRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
