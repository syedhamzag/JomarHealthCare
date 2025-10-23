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
    public class CompanyBankRepository: GenericRepository<CompanyBank>, ICompanyBankRepository
    {
        public CompanyBankRepository(MyCareDbContext context): base(context)
        {
            
        }
    }
}
