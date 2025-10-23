using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class MedicationManufacturerRepository:GenericRepository<MedicationManufacturer>, IMedicationManufacturerRepository
    {
        public MedicationManufacturerRepository(MyCareDbContext context):base(context)
        {
            
        }
    }
}
