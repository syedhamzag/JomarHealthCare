using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class JobPositionRepository : GenericRepository<JobPosition>, IJobPositionRepository
{
    public JobPositionRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
