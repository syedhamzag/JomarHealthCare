using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffContractQueryHandler : IRequestHandler<StaffContractQuery, IQueryable<StaffContract>>
    {
        private readonly IStaffContractRepository _repository;

        public StaffContractQueryHandler(IStaffContractRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffContract>> Handle(StaffContractQuery request, CancellationToken cancellationToken)
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