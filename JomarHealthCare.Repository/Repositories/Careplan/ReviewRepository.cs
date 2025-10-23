using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.CarePlan;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Careplan;

public class ReviewRepository : GenericRepository<Review>, IReviewRepository
{
    public ReviewRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
