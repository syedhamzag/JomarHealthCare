using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffHealthQueryHandler : IRequestHandler<StaffHealthQuery, IQueryable<StaffHealth>>
    {
        private readonly IStaffHealthRepository _repository;

        public StaffHealthQueryHandler(IStaffHealthRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffHealth>> Handle(StaffHealthQuery request, CancellationToken cancellationToken)
        {
            var key = request.Id.ToString().Trim();
            if (!string.IsNullOrEmpty(request.Id))
            {
                return _repository.Get(x => x.StaffPersonalInfoId.ToString().Trim() == key);
            }
            return _repository.Get();
        }
    }
}