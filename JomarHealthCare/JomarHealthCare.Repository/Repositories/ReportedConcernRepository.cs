using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class ReportedConcernRepository : GenericRepository<ReportedConcern>, IReportedConcernRepository
{
    public ReportedConcernRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
