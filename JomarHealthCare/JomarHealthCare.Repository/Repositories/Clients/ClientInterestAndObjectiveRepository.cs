using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientInterestAndObjectiveRepository : GenericRepository<InterestAndObjective>, IClientInterestAndObjectiveRepository
{
    public ClientInterestAndObjectiveRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
