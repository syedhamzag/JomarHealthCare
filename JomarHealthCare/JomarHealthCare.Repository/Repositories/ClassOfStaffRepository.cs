using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class ClassOfStaffRepository : GenericRepository<ClassOfStaff>, IClassOfStaffRepository
    {
        public ClassOfStaffRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
