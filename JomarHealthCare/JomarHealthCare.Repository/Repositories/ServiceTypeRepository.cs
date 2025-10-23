using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

internal class ServiceTypeRepository : GenericRepository<ServiceType>, IServiceTypeRepository
{
    public ServiceTypeRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}