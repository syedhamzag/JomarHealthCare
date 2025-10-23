using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffAdlObsRepository : GenericRepository<StaffAdlObs>, IStaffAdlObsRepository
    {
        public StaffAdlObsRepository(MyCareDbContext context) : base(context)
        {

        }
    }
}
