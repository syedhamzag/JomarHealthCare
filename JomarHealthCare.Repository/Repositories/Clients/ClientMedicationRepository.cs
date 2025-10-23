using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientMedicationRepository : GenericRepository<ClientMedication>, IClientMedicationRepository
{
    public ClientMedicationRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
