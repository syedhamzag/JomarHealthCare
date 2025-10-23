using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffTrainingHandler : IRequestHandler<CreateStaffTrainingCommand, StaffTrainingDataModel>
    {
        private readonly IStaffTrainingRepository _repo;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public CreateStaffTrainingHandler(IStaffTrainingRepository repo, IMapper mapper, IUnitOfWork uow, IStaffPersonalInfoRepository staffPersonalInfoRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }

        public async Task<StaffTrainingDataModel> Handle(CreateStaffTrainingCommand request, CancellationToken cancellationToken)
        {
            var staffPersonalInfo=await _staffPersonalInfoRepository.Get(x=>x.StaffPersonalInfoId==request.DataModel.StaffPersonalInfoId).FirstOrDefaultAsync();
            if (staffPersonalInfo == null)
            {
                throw new ArgumentException($"Staff with ID {request.DataModel.StaffPersonalInfoId} not found.");
            }

            var entity = _mapper.Map<StaffTraining>(request.DataModel);
            var result = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffTrainingDataModel>(result);
        }
    }
}