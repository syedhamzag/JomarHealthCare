using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Domain.Enums;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class ChangeStaffPersonalInfoCommandHandler : IRequestHandler<ChangeStaffPersonalInfoCommand, OnboardStaffDataModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public ChangeStaffPersonalInfoCommandHandler(IStaffPersonalInfoRepository staffPersonalInfoRepository, IMapper mapper, IUnitOfWork unitOfWork, IApplicationUserRepository applicationUserRepository)
        {
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<OnboardStaffDataModel> Handle(ChangeStaffPersonalInfoCommand request, CancellationToken cancellationToken)
        {
            var requestData = request.DataModel;
            var staffId = requestData.StaffPersonalInfoId;
            var status = requestData.Status;
            var staff = await _staffPersonalInfoRepository
                .Get(x => x.StaffPersonalInfoId.ToString() == staffId.ToString())
                .FirstOrDefaultAsync(cancellationToken);

            if (staff == null)
            {
                throw new Exception("Invalid Staff Id: Staff not found");
            }
            var updatedStaff = await ChangeStaffStatus(staff, status);
            if (updatedStaff == null)
            {
                throw new Exception("Failed to update staff status");
            }
            return _mapper.Map<OnboardStaffDataModel>(updatedStaff);
        }

        private async Task<StaffPersonalInfo> ChangeStaffStatus(StaffPersonalInfo staff , StaffStatusEnum status)
        {
            if (staff == null)
            {
                throw new ArgumentNullException(nameof(staff), "Staff cannot be null");
            }
            switch (status)
            {
                case StaffStatusEnum.Active:
                    staff.IsActive=true;
                    break;
                case StaffStatusEnum.NonActive:
                    staff.IsActive = false;
                    break;
                case StaffStatusEnum.OfficeStaff:
                    staff.IsOfficeStaff=true;
                    break;
                case StaffStatusEnum.Applicant:
                    staff.IsApplicant = true;
                    break;
                case StaffStatusEnum.AgencyStaff:
                    staff.IsAgencyStaff = true;
                    break;
                default:
                    return null;
            }
            _staffPersonalInfoRepository.Update(staff);
            await _unitOfWork.SaveChangesAsync();
            return staff;
        }
    }
}