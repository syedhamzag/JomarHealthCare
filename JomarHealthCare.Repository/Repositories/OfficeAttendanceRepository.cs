using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class OfficeAttendanceRepository : GenericRepository<OfficeAttendance>, IOfficeAttendanceRepository
    {
        public OfficeAttendanceRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
