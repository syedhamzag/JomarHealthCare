using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class IncidentDetailRepository : GenericRepository<IncidentDetail>, IIncidentDetailRepository
{
    public IncidentDetailRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}