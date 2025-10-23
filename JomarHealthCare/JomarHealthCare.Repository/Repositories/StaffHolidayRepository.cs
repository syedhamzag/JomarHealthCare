using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffHolidayRepository : GenericRepository<StaffHoliday>, IStaffHolidayRepository
    {
        public StaffHolidayRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
