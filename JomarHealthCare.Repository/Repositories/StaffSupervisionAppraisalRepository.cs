using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffSupervisionAppraisalRepository : GenericRepository<StaffSupervisionAppraisal>, IStaffSupervisionAppraisalRepository
    {
        public StaffSupervisionAppraisalRepository(MyCareDbContext context): base(context)
        {
            
        }
    }
}
