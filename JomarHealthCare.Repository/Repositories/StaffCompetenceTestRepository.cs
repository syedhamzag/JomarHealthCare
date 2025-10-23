using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffCompetenceTestRepository : GenericRepository<StaffCompetenceTest>, IStaffCompetenceTestRepository
    {
        public StaffCompetenceTestRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
