using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffEmergencyContactRepository : GenericRepository<StaffEmergencyContact>, IStaffEmergencyContactRepository
    {
        public StaffEmergencyContactRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
