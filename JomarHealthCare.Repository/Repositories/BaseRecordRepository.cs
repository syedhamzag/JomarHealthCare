using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class BaseRecordRepository : GenericRepository<BaseRecordModel>, IBaseRecordRepository
{
    public BaseRecordRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
