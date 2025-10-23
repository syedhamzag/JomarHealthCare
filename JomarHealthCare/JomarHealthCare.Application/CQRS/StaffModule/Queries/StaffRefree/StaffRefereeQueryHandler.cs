using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffRefereeQueryHandler : IRequestHandler<StaffRefereeQuery, IQueryable<StaffReferee>>
    {
        private readonly IStaffRefereeRepository _repository;

        public StaffRefereeQueryHandler(IStaffRefereeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffReferee>> Handle(StaffRefereeQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffPersonalInfoId.ToString().Trim() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}