using JomarHealthCare.Application;
using JomarHealthCare.Application.Repositories.Clients;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Repository.Repositories.Clients;

public class HomeRiskAssessmentRepository : GenericRepository<HomeRiskAssessment>, IHomeRiskAssessmentRepository
{
    public HomeRiskAssessmentRepository(IUnitOfWork dbContext) : base(dbContext)
    {
    }
    // Additional methods specific to HomeRiskAssessment can be added here if needed
}
