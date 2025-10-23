using AutoMapper;
using MediatR;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class UpdateStaffEducationHandler : IRequestHandler<UpdateStaffEducationCommand, bool>
    {
        private readonly IStaffEducationRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStaffEducationHandler(IStaffEducationRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateStaffEducationCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffEducation>(request.DataModel);
            _repo.Update(entity);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}