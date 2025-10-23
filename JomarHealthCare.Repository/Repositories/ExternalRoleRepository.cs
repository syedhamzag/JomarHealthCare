using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class ExternalRoleRepository : GenericRepository<ExternalRole>, IExternalRoleRepository
{
    public ExternalRoleRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}