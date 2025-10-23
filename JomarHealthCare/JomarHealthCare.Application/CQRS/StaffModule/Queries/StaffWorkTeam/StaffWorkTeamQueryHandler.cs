using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffWorkTeamQueryHandler : IRequestHandler<StaffWorkTeamQuery, IQueryable<StaffWorkTeam>>
    {
        private readonly IStaffWorkTeamRepository _repository;

        public StaffWorkTeamQueryHandler(IStaffWorkTeamRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffWorkTeam>> Handle(StaffWorkTeamQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffWorkTeamId.ToString().Trim() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}