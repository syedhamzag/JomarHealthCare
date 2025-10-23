using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    internal class StaffCompetenceTestQueryHandler : IRequestHandler<StaffCompetenceTestQuery, IQueryable<StaffCompetenceTest>>
    {
        private readonly IStaffCompetenceTestRepository _repository;

        public StaffCompetenceTestQueryHandler(IStaffCompetenceTestRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffCompetenceTest>> Handle(StaffCompetenceTestQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(key.ToString().Trim()))
            {
                return _repository.Get(x => x.StaffPersonalInfoId.ToString() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}
