using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class InterviewQuestionQueryHandler : IRequestHandler<InterviewQuestionQuery, IQueryable<InterviewQuestion>>
    {
        private readonly IInterviewQuestionRepository _repository;

        public InterviewQuestionQueryHandler(IInterviewQuestionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<InterviewQuestion>> Handle(InterviewQuestionQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id.ToString().Trim();
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.Id.ToString().Trim() == key);
            }
            return _repository.Get();
        }
    }
}