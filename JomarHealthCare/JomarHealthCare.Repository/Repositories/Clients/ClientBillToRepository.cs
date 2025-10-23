using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientBillToRepository : GenericRepository<ClientBillTo>, IClientBillToRepository
{
    public ClientBillToRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
    // Additional methods specific to ClientBillTo can be added here if needed
}
