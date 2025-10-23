using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class AppMessageRepository : GenericRepository<AppMessage>, IAppMessageRepository
    {
        public AppMessageRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
