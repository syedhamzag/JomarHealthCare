using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffWorkTeamRepository : GenericRepository<StaffWorkTeam>, IStaffWorkTeamRepository
    {
        public StaffWorkTeamRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
