using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffEmergencyContactHandler : IRequestHandler<UpdateStaffEmergencyContactCommand, bool>
    {
        private readonly IStaffEmergencyContactRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStaffEmergencyContactHandler(IStaffEmergencyContactRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateStaffEmergencyContactCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffEmergencyContact>(request.DataModel);
            _repo.Update(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }







}