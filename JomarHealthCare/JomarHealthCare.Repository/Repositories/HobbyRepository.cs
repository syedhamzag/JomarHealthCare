using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class HobbyRepository : GenericRepository<Hobbies>, IHobbyRepository
{
    public HobbyRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
