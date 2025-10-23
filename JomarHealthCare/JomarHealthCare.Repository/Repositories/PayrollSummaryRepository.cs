using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Repository.Repositories
{
    public class PayrollSummaryRepository: GenericRepository<PayrollSummary>, IPayrollSummaryRepository
    {
        public PayrollSummaryRepository(MyCareDbContext context):base(context)
        {
            
        }
    }
}
