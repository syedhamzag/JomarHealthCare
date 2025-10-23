using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class ComplainRegistorRepository : GenericRepository<ComplainRegistor>, IComplainRegistorRepository
    {
        public ComplainRegistorRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
