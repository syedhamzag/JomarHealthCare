using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class CandidateInterviewRepository : GenericRepository<CandidateInterview>, ICandidateInterviewRepository
    {
        public CandidateInterviewRepository(MyCareDbContext context): base(context)
        {
            
        }
    }
}
