using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    internal class StaffShadowingQueryHandler : IRequestHandler<StaffShadowingQuery, IQueryable<StaffShadowing>>
    {
        private readonly IStaffShadowingRepository _repository;

        public StaffShadowingQueryHandler(IStaffShadowingRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffShadowing>> Handle(StaffShadowingQuery request, CancellationToken cancellationToken)
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
