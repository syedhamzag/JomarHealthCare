using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffAdlObsQueryHandler : IRequestHandler<StaffAdlObsQuery, IQueryable<StaffAdlObs>>
    {
        private readonly IStaffAdlObsRepository _userRepository;

        public StaffAdlObsQueryHandler(IStaffAdlObsRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IQueryable<StaffAdlObs>> Handle(StaffAdlObsQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _userRepository.Get(x => x.StaffId.ToString().Trim() == key.ToString().Trim());
            }
            return _userRepository.Get();
        }
    }
}