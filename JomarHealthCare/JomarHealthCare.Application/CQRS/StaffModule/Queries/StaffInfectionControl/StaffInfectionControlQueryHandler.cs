using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffInfectionControlQueryHandler : IRequestHandler<StaffInfectionControlQuery, IQueryable<StaffInfectionControl>>
    {
        private readonly IStaffInfectionControlRepository _repository;

        public StaffInfectionControlQueryHandler(IStaffInfectionControlRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffInfectionControl>> Handle(StaffInfectionControlQuery request, CancellationToken cancellationToken)
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