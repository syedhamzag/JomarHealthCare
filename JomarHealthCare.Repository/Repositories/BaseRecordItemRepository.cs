using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class BaseRecordItemRepository : GenericRepository<BaseRecordItemModel>, IBaseRecordItemRepository
{
    public BaseRecordItemRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
