using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Queries
{
   public class StaffEducationQueryHandler : IRequestHandler<StaffEducationQuery, IQueryable<StaffEducation>>
    {
        private readonly IStaffEducationRepository _repository;

        public StaffEducationQueryHandler(IStaffEducationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<StaffEducation>> Handle(StaffEducationQuery request, CancellationToken cancellationToken)
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