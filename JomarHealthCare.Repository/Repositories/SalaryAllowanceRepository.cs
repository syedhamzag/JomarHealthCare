using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class SalaryAllowanceRepository : GenericRepository<SalaryAllowance>, ISalaryAllowanceRepository
    {
        public SalaryAllowanceRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
