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
    public class StaffOneToOneRepository : GenericRepository<StaffOneToOne>, IStaffOneToOneRepository
    {
        public StaffOneToOneRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
