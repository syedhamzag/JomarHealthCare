using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffTrainingByListRepository : GenericRepository<StaffTrainingByList>, IStaffTrainingByListRepository
    {
        public StaffTrainingByListRepository(MyCareDbContext context) : base(context)
        {

        }
    }
}
