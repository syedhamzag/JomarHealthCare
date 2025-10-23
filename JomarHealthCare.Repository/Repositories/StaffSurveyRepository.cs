using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories
{
    public class StaffSurveyRepository : GenericRepository<StaffSurvey>, IStaffSurveyRepository
    {
        public StaffSurveyRepository(IUnitOfWork dbContext) : base(dbContext)
        {
        }
    }
}
