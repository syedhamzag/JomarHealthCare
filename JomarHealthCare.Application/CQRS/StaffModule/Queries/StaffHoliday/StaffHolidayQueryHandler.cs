using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffHolidayQueryHandler : IRequestHandler<StaffHolidayQuery, IQueryable<StaffHoliday>>
    {
        private readonly IStaffHolidayRepository _repository;

        public StaffHolidayQueryHandler(IStaffHolidayRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffHoliday>> Handle(StaffHolidayQuery request, CancellationToken cancellationToken)
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