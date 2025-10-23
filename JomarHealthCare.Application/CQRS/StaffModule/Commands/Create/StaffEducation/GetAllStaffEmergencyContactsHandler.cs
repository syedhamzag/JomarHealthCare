using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class GetAllStaffEmergencyContactsHandler : IRequestHandler<GetAllStaffEmergencyContactsQuery, IQueryable<StaffEmergencyContact>>
    {
        private readonly IStaffEmergencyContactRepository _repo;
        private readonly IMapper _mapper;

        public GetAllStaffEmergencyContactsHandler(IStaffEmergencyContactRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IQueryable<StaffEmergencyContact>> Handle(GetAllStaffEmergencyContactsQuery request, CancellationToken cancellationToken)
        {
            var queryableData = _repo.Get();
            return queryableData;
        }
    }
}