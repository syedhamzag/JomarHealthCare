using JomarHealthCare.Domain.Enums;
using System.Text.Json.Serialization;

namespace JomarHealthCare.Application.DataModels.Staff
{

    public class ApplicationUserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? CompanyId { get; set; }
        public string Fullname { get; set; }
    }
    public class ChangeStaffStatusDataModel
    {
        public Guid StaffPersonalInfoId { get; set; }
        public StaffStatusEnum Status { get; set; }
    }
    public class OnboardUpdateStaffDataModel
    {
        public string data { get; set; }
    }

    public class OnboardStaffDataModel
    {
        /// <summary>
        ///  ApplicationUser Id - ForeignKey Reference
        /// </summary>
        public Guid StaffPersonalInfoId { get; set; }

        public string RegistrationId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Telephone { get; set; }
        public string ProfilePix { get; set; }
        public string Address { get; set; }
        public string AboutMe { get; set; }
        public string Hobbies { get; set; }
        public string Email { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Keyworker { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public string PostCode { get; set; }
        public decimal? Rate { get; set; }
        public string TeamLeader { get; set; }
        public string WorkTeam { get; set; }
        public int? StaffWorkTeamId { get; set; }
        public string Passcode { get; set; }
        public bool CanDrive { get; set; }
        public string DrivingLicense { get; set; }
        public DateTime? DrivingLicenseExpiryDate { get; set; }
        public bool RightToWork { get; set; }
        public string RightToWorkAttachment { get; set; }
        public DateTime? RightToWorkExpiryDate { get; set; }
        public bool DBS { get; set; }
        public string DBSAttachment { get; set; }
        public DateTime? DBSExpiryDate { get; set; }
        public string DBSUpdateNo { get; set; }
        public bool NI { get; set; }
        public string NIAttachment { get; set; }
        public DateTime? NIExpiryDate { get; set; }

        public string CV { get; set; }
        public string CoverLetter { get; set; }
        public bool Self_PYE { get; set; }
        public string Self_PYEAttachment { get; set; }
        public StaffRegistrationEnum Status { get; set; }

        public bool IsTeamLeader { get; set; }
        public bool IsKeyWorker { get; set; }
        public bool HasUniform { get; set; }
        public bool HasIdCard { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public int? CategoryId { get; set; }
        public string PlaceOfBirth { get; set; }
        public Guid? CompanyId { get; set; }
        public string StaffManager { get; set; }
        public int? JobPositionId { get; set; }
        public bool IsAgencyStaff { get; set; }
        public bool IsOfficeStaff { get; set; }
        public bool IsApplicant { get; set; }

        public string ClassOfStaff { get; set; }
        public string COSNo { get; set; }
        public string BRPAttachment { get; set; }
        public string PassportAttachment { get; set; }
        public decimal? GrossSalary { get; set; }
        public string RegistrationNo { get; set; }
        public string HomeOfficeDecisionLetter { get; set; }

        public bool RightToPractice { get; set; }
        public string RightToPracticeAttachment { get; set; }
        public string RightToPracticeCode { get; set; }
        public DateTime? RightToPracticeExpiryDate { get; set; }
    }
    public class OnboardStaffAccountDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyCode { get; set; }
        [JsonIgnore]
        public Guid CompanyId { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
    }


    public class OnboardByCompanyStaffAccountDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string PlaceOfBirth { get; set; }
        public int? CategoryId { get; set; }
        public int? JobPositionId { get; set; }
        public Guid? CompanyId { get; set; }
        public string CompanyInitialName { get; set; }
    }


    public class GetStaffByCompanyDataModel
    {
        public Guid StaffPersonalInfoId { get; set; }
        public string Fullname { get; set; }
        public string RegistrationId { get; set; }
        public string ProfilePix { get; set; }
        public string Telephone { get; set; }
        public DateTime? StartDate { get; set; }
        public StaffRegistrationEnum StaffStatus { get; set; }
        public string Email { get; set; }
        public bool CanDrive { get; set; }
        public bool IsAgency { get; set; }
        public bool IsOfficeStaff { get; set; }
        public bool IsApplicant { get; set; }
        public bool IsActive { get; set; }
    }
}