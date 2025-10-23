using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffPersonalityTestRepository : GenericRepository<StaffPersonalityTest>, IStaffPersonalityTestRepository
    {
        public StaffPersonalityTestRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
