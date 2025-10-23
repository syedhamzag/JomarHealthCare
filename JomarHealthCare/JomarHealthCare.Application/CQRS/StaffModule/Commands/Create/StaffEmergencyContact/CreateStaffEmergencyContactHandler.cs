using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffEmergencyContactHandler : IRequestHandler<CreateStaffEmergencyContactCommand, StaffEmergencyContactDataModel>
    {
        private readonly IStaffEmergencyContactRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateStaffEmergencyContactHandler(IStaffEmergencyContactRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StaffEmergencyContactDataModel> Handle(CreateStaffEmergencyContactCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffEmergencyContact>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffEmergencyContactDataModel>(created);
        }
    }
}