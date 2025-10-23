using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    internal class StaffPersonalityTestQueryHandler : IRequestHandler<StaffPersonalityTestQuery, IQueryable<StaffPersonalityTest>>
    {
        private readonly IStaffPersonalityTestRepository _repository;

        public StaffPersonalityTestQueryHandler(IStaffPersonalityTestRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffPersonalityTest>> Handle(StaffPersonalityTestQuery request, CancellationToken cancellationToken)
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
