using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffShadowingRepository : GenericRepository<StaffShadowing>, IStaffShadowingRepository
    {
        public StaffShadowingRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
