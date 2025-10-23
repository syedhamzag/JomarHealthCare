using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
    public class StaffEmergencyContactQueryHandler : IRequestHandler<StaffEmergencyContactQuery, IQueryable<StaffEmergencyContact>>
    {
        private readonly IStaffEmergencyContactRepository _repository;

        public StaffEmergencyContactQueryHandler(IStaffEmergencyContactRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffEmergencyContact>> Handle(StaffEmergencyContactQuery request, CancellationToken cancellationToken)
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