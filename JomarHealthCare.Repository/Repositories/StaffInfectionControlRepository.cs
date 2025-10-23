using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffInfectionControlRepository : GenericRepository<StaffInfectionControl>, IStaffInfectionControlRepository
    {
        public StaffInfectionControlRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
