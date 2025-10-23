using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class ExternalRoleAccessRepository : GenericRepository<ExternalRoleAccess>, IExternalRoleAccessRepository
{
    public ExternalRoleAccessRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}