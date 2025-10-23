using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.HumanResourcesModule.Queries
{
    public class OfficeAttendanceQueryHandler : IRequestHandler<OfficeAttendanceQuery, IQueryable<OfficeAttendance>>
    {
        private readonly IOfficeAttendanceRepository _repo;

        public OfficeAttendanceQueryHandler(IOfficeAttendanceRepository repo)
        {
            _repo = repo;
        }

        public async Task<IQueryable<OfficeAttendance>> Handle(OfficeAttendanceQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id?.Trim();
            if (!string.IsNullOrEmpty(key))
                return _repo.Get(x => x.AttendanceId.ToString() == key);

            return _repo.Get();
        }
    }
}