using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class IncidentTypeRepository : GenericRepository<IncidentType>, IIncidentTypeRepository
{
    public IncidentTypeRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
