using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientProgramRepository : GenericRepository<ClientProgram>, IClientProgramRepository
{
    public ClientProgramRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
