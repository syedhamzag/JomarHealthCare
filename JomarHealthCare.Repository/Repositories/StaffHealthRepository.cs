using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffHealthRepository : GenericRepository<StaffHealth>, IStaffHealthRepository
    {
        public StaffHealthRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
