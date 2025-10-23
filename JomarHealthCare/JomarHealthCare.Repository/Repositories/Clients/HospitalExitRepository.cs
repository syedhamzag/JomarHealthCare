using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class HospitalExitRepository : GenericRepository<HospitalExit>, IHospitalExitRepository
{
    public HospitalExitRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
