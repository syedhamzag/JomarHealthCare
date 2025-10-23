using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientBestInterestRepository : GenericRepository<BestInterestAssessment>, IClientBestInterestRepository
{
    public ClientBestInterestRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
