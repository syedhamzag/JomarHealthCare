using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffMedCompRepository : GenericRepository<StaffMedComp>, IStaffMedCompRepository
    {
        public StaffMedCompRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
