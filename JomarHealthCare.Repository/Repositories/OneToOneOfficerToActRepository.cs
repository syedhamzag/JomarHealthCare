using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class OneToOneOfficerToActRepository : GenericRepository<OneToOneOfficerToAct>, IOneToOneOfficerToActRepository
    {
        public OneToOneOfficerToActRepository(MyCareDbContext context): base(context)
        {
            
        }
    }
}
