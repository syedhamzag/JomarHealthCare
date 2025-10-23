using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffMedCompQueryHandler : IRequestHandler<StaffMedCompQuery, IQueryable<StaffMedComp>>
    {
        private readonly IStaffMedCompRepository _repository;

        public StaffMedCompQueryHandler(IStaffMedCompRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffMedComp>> Handle(StaffMedCompQuery request, CancellationToken cancellationToken)
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