using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class CandidateInterviewQueryHandler : IRequestHandler<CandidateInterviewQuery, IQueryable<CandidateInterview>>
    {
        private readonly ICandidateInterviewRepository _repository;

        public CandidateInterviewQueryHandler(ICandidateInterviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<CandidateInterview>> Handle(CandidateInterviewQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id.ToString().Trim();
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffId.ToString().Trim() == key);
            }
            return _repository.Get();
        }
    }
}