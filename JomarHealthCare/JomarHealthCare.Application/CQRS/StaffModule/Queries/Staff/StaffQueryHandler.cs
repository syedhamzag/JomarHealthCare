using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffQueryHandler : IRequestHandler<StaffQuery, IQueryable<ApplicationUser>>
    {
        private readonly IApplicationUserRepository _userRepository;

        public StaffQueryHandler(IApplicationUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IQueryable<ApplicationUser>> Handle(StaffQuery request, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _userRepository.Get(x => x.Id == request.Id);
            }
            return _userRepository.Get();
        }
    }
}