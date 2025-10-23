using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class ClientEquipmentAssessmentRepository : GenericRepository<EquipmentAssessment>, IClientEquipmentAssessmentRepository
{
    public ClientEquipmentAssessmentRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
