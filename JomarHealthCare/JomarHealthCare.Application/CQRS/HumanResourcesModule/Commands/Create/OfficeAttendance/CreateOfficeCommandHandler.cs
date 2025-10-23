using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.HumanResourcesModule;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class CreateOfficeCommandHandler : IRequestHandler<CreateOfficeAttendanceCommand, OfficeAttendanceDataModel>
    {
        private readonly IOfficeAttendanceRepository _repo;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateOfficeCommandHandler(IOfficeAttendanceRepository repo, IMapper mapper, IUnitOfWork uow, IStaffPersonalInfoRepository staffPersonalInfoRepository, IApplicationUserRepository applicationUserRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _applicationUserRepository = applicationUserRepository;
        }

        public async Task<OfficeAttendanceDataModel> Handle(CreateOfficeAttendanceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<OfficeAttendance>(request.DataModel);
            var user = await _applicationUserRepository.Get(x=>x.Id.ToString()==request.DataModel.CreatedBy).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {request.DataModel.CreatedBy} not found.");
            }
            var result = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<OfficeAttendanceDataModel>(result);
        }
    }
}
