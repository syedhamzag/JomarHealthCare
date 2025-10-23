using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class ClientTaskBoardRepository : GenericRepository<ClientTaskBoard>, IClientTaskBoardRepository
{
    public ClientTaskBoardRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
