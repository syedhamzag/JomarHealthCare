using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class CompanyMessageRepository : GenericRepository<CompanyMessage>, ICompanyMessageRepository
    {
        public CompanyMessageRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
