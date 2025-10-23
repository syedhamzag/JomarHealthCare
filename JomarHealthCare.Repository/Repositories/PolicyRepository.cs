using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class PolicyRepository : GenericRepository<Policies>, IPolicyRepository
{
    public PolicyRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
