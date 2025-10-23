using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientCarePlanNutritionRepository : GenericRepository<CarePlanNutrition>, IClientCarePlanNutritionRepository
{
    public ClientCarePlanNutritionRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
