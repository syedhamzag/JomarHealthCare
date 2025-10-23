using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffPersonalInfoRepository : GenericRepository<StaffPersonalInfo>, IStaffPersonalInfoRepository
    {
        public StaffPersonalInfoRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
