using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffHolidayHandler : IRequestHandler<CreateStaffHolidayCommand, StaffHolidayDataModel>
    {
        private readonly IStaffHolidayRepository _repo;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CreateStaffHolidayHandler(IStaffHolidayRepository repo, IMapper mapper, IUnitOfWork uow, IStaffPersonalInfoRepository staffPersonalInfoRepository, ICompanyRepository companyRepository)
        {
            _repo = repo;
            _mapper = mapper;
            _uow = uow;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _companyRepository = companyRepository;
        }

        public async Task<StaffHolidayDataModel> Handle(CreateStaffHolidayCommand request, CancellationToken cancellationToken)
        {
            var staffPersonalInfo = await _staffPersonalInfoRepository.Get(x => x.StaffPersonalInfoId == request.DataModel.StaffPersonalInfoId).FirstOrDefaultAsync();
            if (staffPersonalInfo == null)
            {
                throw new ArgumentException($"StaffPersonalInfo with ID {request.DataModel.StaffPersonalInfoId} not found.");
            }
            var company = await _companyRepository.Get(x => x.CompanyId == staffPersonalInfo.CompanyId).FirstOrDefaultAsync();
            if (company == null)
            {
                throw new ArgumentException($"Company with ID {staffPersonalInfo.CompanyId} not found.");
            }
            if (company.CompanyId != request.DataModel.CompanyId)
            {
                throw new ArgumentException($"Company ID mismatch: {company.CompanyId} does not match {request.DataModel.CompanyId}.");
            }
            if (staffPersonalInfo.StaffPersonalInfoId != request.DataModel.StaffPersonalInfoId)
            {
                throw new ArgumentException($"StaffPersonalInfo ID mismatch: {staffPersonalInfo.StaffPersonalInfoId} does not match {request.DataModel.StaffPersonalInfoId}.");
            }
            var entity = _mapper.Map<StaffHoliday>(request.DataModel);
            var created = await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return _mapper.Map<StaffHolidayDataModel>(created);
        }
    }
}