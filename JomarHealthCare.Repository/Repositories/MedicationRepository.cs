using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class MedicationRepository: GenericRepository<Medication>, IMedicationRepository
    {
        public MedicationRepository(MyCareDbContext context):base(context)
        {
            
        }
    }
}
