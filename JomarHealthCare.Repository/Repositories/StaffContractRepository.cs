using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffContractRepository : GenericRepository<StaffContract>, IStaffContractRepository
    {
        public StaffContractRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
