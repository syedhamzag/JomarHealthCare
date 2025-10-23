using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using JomarHealthCare.Application.Abstractions;
using JomarHealthCare.Application.DataModels.Staff;
using JomarHealthCare.Application.Repositories;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    internal class UpdateStaffPersonalInfoCommandHandler : IRequestHandler<UpdateStaffPersonalInfoCommand, OnboardStaffDataModel>
    {
        private readonly IEmailService emailService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IMapper _mapper;
        private readonly IStaffPersonalInfoRepository _staffPersonalInfoRepository;

        public UpdateStaffPersonalInfoCommandHandler(IEmailService emailService, IStaffPersonalInfoRepository staffPersonalInfoRepository, IMapper mapper, IUnitOfWork unitOfWork, IApplicationUserRepository applicationUserRepository)
        {
            this.emailService = emailService;
            _staffPersonalInfoRepository = staffPersonalInfoRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<OnboardStaffDataModel> Handle(UpdateStaffPersonalInfoCommand request, CancellationToken cancellationToken)
        {
            var requestData = request.DataModel;

            var staff = await _staffPersonalInfoRepository
                .Get(x => x.StaffPersonalInfoId.ToString() == request.Id.ToString()) 
                .FirstOrDefaultAsync(cancellationToken);

            if (staff == null)
            {
                throw new Exception("Invalid Staff Id: Staff not found");
            }

            if (!string.IsNullOrEmpty(requestData.FirstName)) staff.FirstName = requestData.FirstName;
            if (!string.IsNullOrEmpty(requestData.MiddleName)) staff.MiddleName = requestData.MiddleName;
            if (!string.IsNullOrEmpty(requestData.LastName)) staff.LastName = requestData.LastName;
            if (requestData.DateOfBirth != default) staff.DateOfBirth = requestData.DateOfBirth;
            if (!string.IsNullOrEmpty(requestData.Telephone)) staff.Telephone = requestData.Telephone;
            if (!string.IsNullOrEmpty(requestData.Address)) staff.Address = requestData.Address;
            if (!string.IsNullOrEmpty(requestData.ProfilePix)) staff.ProfilePix = requestData.ProfilePix;
            if (!string.IsNullOrEmpty(requestData.Email)) staff.Email = requestData.Email;
            if (!string.IsNullOrEmpty(requestData.Gender)) staff.Gender = requestData.Gender;

            staff.AboutMe = requestData.AboutMe ?? staff.AboutMe;
            staff.Hobbies = requestData.Hobbies ?? staff.Hobbies;
            staff.PostCode = requestData.PostCode ?? staff.PostCode;
            staff.Rate = requestData.Rate ?? staff.Rate;
            staff.StartDate = requestData.StartDate != default ? requestData.StartDate : staff.StartDate;
            staff.EndDate = requestData.EndDate ?? staff.EndDate;
            staff.Keyworker = requestData.Keyworker ?? staff.Keyworker;
            staff.IdNumber = requestData.IdNumber ?? staff.IdNumber;

            staff.TeamLeader = requestData.TeamLeader ?? staff.TeamLeader;
            staff.WorkTeam = requestData.WorkTeam ?? staff.WorkTeam;
            //staff.StaffWorkTeamId = requestData.StaffWorkTeamId ?? staff.StaffWorkTeamId;
            staff.Passcode = requestData.Passcode ?? staff.Passcode;

            staff.CanDrive = requestData.CanDrive;
            staff.DrivingLicense = requestData.DrivingLicense ?? staff.DrivingLicense;
            staff.DrivingLicenseExpiryDate = requestData.DrivingLicenseExpiryDate ?? staff.DrivingLicenseExpiryDate;

            staff.RightToWork = requestData.RightToWork;
            staff.RightToWorkAttachment = requestData.RightToWorkAttachment ?? staff.RightToWorkAttachment;
            staff.RightToWorkExpiryDate = requestData.RightToWorkExpiryDate ?? staff.RightToWorkExpiryDate;

            staff.DBS = requestData.DBS;
            staff.DBSAttachment = requestData.DBSAttachment ?? staff.DBSAttachment;
            staff.DBSExpiryDate = requestData.DBSExpiryDate ?? staff.DBSExpiryDate;
            staff.DBSUpdateNo = requestData.DBSUpdateNo ?? staff.DBSUpdateNo;

            staff.NI = requestData.NI;
            staff.NIAttachment = requestData.NIAttachment ?? staff.NIAttachment;
            staff.NIExpiryDate = requestData.NIExpiryDate ?? staff.NIExpiryDate;

            staff.CV = requestData.CV ?? staff.CV;
            staff.CoverLetter = requestData.CoverLetter ?? staff.CoverLetter;
            staff.Self_PYE = requestData.Self_PYE;
            staff.Self_PYEAttachment = requestData.Self_PYEAttachment ?? staff.Self_PYEAttachment;

            staff.IsTeamLeader = requestData.IsTeamLeader;
            staff.IsKeyWorker = requestData.IsKeyWorker;
            staff.HasUniform = requestData.HasUniform;
            staff.HasIdCard = requestData.HasIdCard;
            staff.EmploymentDate = requestData.EmploymentDate ?? staff.EmploymentDate;

            //staff.CategoryId = requestData.CategoryId ?? staff.CategoryId;
            staff.PlaceOfBirth = requestData.PlaceOfBirth ?? staff.PlaceOfBirth;
            staff.StaffManager = requestData.StaffManager ?? staff.StaffManager;
            //staff.JobPositionId = requestData.JobPositionId ?? staff.JobPositionId;
            staff.IsAgencyStaff = requestData.IsAgencyStaff;
            staff.IsOfficeStaff = requestData.IsOfficeStaff;
            staff.IsApplicant = requestData.IsApplicant;

            staff.ClassOfStaff = requestData.ClassOfStaff ?? staff.ClassOfStaff;
            staff.COSNo = requestData.COSNo ?? staff.COSNo;
            staff.BRPAttachment = requestData.BRPAttachment ?? staff.BRPAttachment;
            staff.PassportAttachment = requestData.PassportAttachment ?? staff.PassportAttachment;
            staff.GrossSalary = requestData.GrossSalary ?? staff.GrossSalary;
            staff.RegistrationNo = requestData.RegistrationNo ?? staff.RegistrationNo;
            staff.HomeOfficeDecisionLetter = requestData.HomeOfficeDecisionLetter ?? staff.HomeOfficeDecisionLetter;

            staff.RightToPractice = requestData.RightToPractice;
            staff.RightToPracticeAttachment = requestData.RightToPracticeAttachment ?? staff.RightToPracticeAttachment;
            staff.RightToPracticeCode = requestData.RightToPracticeCode ?? staff.RightToPracticeCode;
            staff.RightToPracticeExpiryDate = requestData.RightToPracticeExpiryDate ?? staff.RightToPracticeExpiryDate;
            _staffPersonalInfoRepository.Update(staff);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return _mapper.Map<OnboardStaffDataModel>(staff);
        }
    }
}