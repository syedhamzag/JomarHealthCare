using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffTrainingRepository : GenericRepository<StaffTraining>, IStaffTrainingRepository
    {
        public StaffTrainingRepository(MyCareDbContext context) : base(context)
        {

        }
    }
}
