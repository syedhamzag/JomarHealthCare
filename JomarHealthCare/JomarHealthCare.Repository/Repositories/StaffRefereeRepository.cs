using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffRefereeRepository : GenericRepository<StaffReferee>, IStaffRefereeRepository
    {
        public StaffRefereeRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
