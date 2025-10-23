using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffOneToOneQueryHandler : IRequestHandler<StaffOneToOneQuery, IQueryable<StaffOneToOne>>
    {
        private readonly IStaffOneToOneRepository _repository;

        public StaffOneToOneQueryHandler(IStaffOneToOneRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffOneToOne>> Handle(StaffOneToOneQuery request, CancellationToken cancellationToken)
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