using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories;

public class CategoryOfStaffRepository : GenericRepository<CategoryOfStaff>, ICategoryOfStaffRepository
{
    public CategoryOfStaffRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
}
