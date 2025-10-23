using AutoMapper;
using MediatR;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffEducationHandler : IRequestHandler<CreateStaffEducationCommand, StaffEducationDataModel>
    {
        private readonly IStaffEducationRepository _repo;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStaffEducationHandler(IStaffEducationRepository repo, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<StaffEducationDataModel> Handle(CreateStaffEducationCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<StaffEducation>(request.DataModel);
            var result = await _repo.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<StaffEducationDataModel>(result);
        }
    }

}