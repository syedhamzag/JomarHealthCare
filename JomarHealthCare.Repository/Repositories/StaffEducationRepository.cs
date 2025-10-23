using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffEducationRepository : GenericRepository<StaffEducation>, IStaffEducationRepository
    {
        public StaffEducationRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
