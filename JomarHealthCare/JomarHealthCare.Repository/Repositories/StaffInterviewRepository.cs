using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffInterviewRepository : GenericRepository<StaffInterview>, IStaffInterviewRepository
    {
        public StaffInterviewRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
