using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientNutritionRepository : GenericRepository<ClientNutrition>, IClientNutritionRepository
{
    public ClientNutritionRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
