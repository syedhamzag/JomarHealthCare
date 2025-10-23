using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public partial class CreateStaffInfectionControlHandler : IRequestHandler<CreateStaffInfectionControlCommand, StaffInfectionControlDataModel>
    {
        private readonly IStaffInfectionControlRepository _repo;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffInfectionControlHandler(IStaffInfectionControlRepository repo, IMapper mapper, IUnitOfWork uow, ICompanyRepository companyRepository, IStaffPersonalInfoRepository staffPersonalInfoRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _companyRepository = companyRepository;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
        }
        public async Task<StaffInfectionControlDataModel> Handle(CreateStaffInfectionControlCommand request, CancellationToken cancellationToken)
        {
            var staffPersonalInfo = await _staffPersonalInfoRepository.Get(x => x.StaffPersonalInfoId == request.DataModel.StaffPersonalInfoId).FirstOrDefaultAsync();
            if (staffPersonalInfo == null)
            {
                throw new ArgumentException($"StaffPersonalInfo with ID {request.DataModel.StaffPersonalInfoId} not found.");
            }  
            var entity = _mapper.Map<StaffInfectionControl>(request.DataModel);
            var saved = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffInfectionControlDataModel>(saved);
        }
    }
}