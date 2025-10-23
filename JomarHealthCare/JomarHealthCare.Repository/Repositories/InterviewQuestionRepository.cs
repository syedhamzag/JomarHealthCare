using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Repository.Database;

namespace JomarHealthCare.Repository.Repositories
{
    public class InterviewQuestionRepository : GenericRepository<InterviewQuestion>, IInterviewQuestionRepository
    {
        public InterviewQuestionRepository(MyCareDbContext context) : base(context)
        {

        }
    }
}
