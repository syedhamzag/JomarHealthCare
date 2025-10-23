using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffSpotCheckRepository : GenericRepository<StaffSpotCheck>, IStaffSpotCheckRepository
    {
        public StaffSpotCheckRepository(MyCareDbContext context): base(context)
        {
            
        }
    }
}
