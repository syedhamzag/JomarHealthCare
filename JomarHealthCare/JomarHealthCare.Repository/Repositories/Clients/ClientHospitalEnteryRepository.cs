using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientHospitalEnteryRepository : GenericRepository<HospitalEntry>, IClientHospitalEnteryRepository
{
    public ClientHospitalEnteryRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
