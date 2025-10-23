using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class JobCategoryRespository : GenericRepository<CategoryOfStaff>, IJobCategoryRepository
{
    public JobCategoryRespository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
