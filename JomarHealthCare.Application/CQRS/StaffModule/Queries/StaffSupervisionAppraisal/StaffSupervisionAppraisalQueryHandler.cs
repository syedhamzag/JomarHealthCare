using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{

    public class StaffSupervisionAppraisalQueryHandler : IRequestHandler<StaffSupervisionAppraisalQuery, IQueryable<StaffSupervisionAppraisal>>
    {
        private readonly IStaffSupervisionAppraisalRepository _repository;

        public StaffSupervisionAppraisalQueryHandler(IStaffSupervisionAppraisalRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffSupervisionAppraisal>> Handle(StaffSupervisionAppraisalQuery request, CancellationToken cancellationToken)
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