using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{

    public class StaffSpotCheckQueryHandler : IRequestHandler<StaffSpotCheckQuery, IQueryable<StaffSpotCheck>>
    {
        private readonly IStaffSpotCheckRepository _repository;

        public StaffSpotCheckQueryHandler(IStaffSpotCheckRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffSpotCheck>> Handle(StaffSpotCheckQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id;
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffId.ToString().Trim() == key.ToString().Trim());
            }
            return _repository.Get();
        }
    }
}