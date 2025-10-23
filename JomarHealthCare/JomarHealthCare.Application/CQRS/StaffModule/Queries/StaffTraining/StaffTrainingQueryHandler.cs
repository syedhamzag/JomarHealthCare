using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffTrainingQueryHandler : IRequestHandler<StaffTrainingQuery, IQueryable<StaffTraining>>
    {
        private readonly IStaffTrainingRepository _repository;

        public StaffTrainingQueryHandler(IStaffTrainingRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffTraining>> Handle(StaffTrainingQuery request, CancellationToken cancellationToken)
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