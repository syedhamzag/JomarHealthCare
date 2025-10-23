using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class MedicationRouteRepository: GenericRepository<MedicationRoute>, IMedicationReouteRepository
    {
        public MedicationRouteRepository(MyCareDbContext context): base(context)
        {
            
        }
    }
}
