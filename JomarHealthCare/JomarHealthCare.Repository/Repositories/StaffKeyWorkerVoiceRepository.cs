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
    public class StaffKeyWorkerVoiceRepository : GenericRepository<StaffKeyWorkerVoice>, IStaffKeyWorkerVoiceRepository
    {
        public StaffKeyWorkerVoiceRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
