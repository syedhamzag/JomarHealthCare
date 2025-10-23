namespace JomarHealthCare.Domain.Enums
{
    public enum StaffRegistrationEnum
    {
        Pending = 0,
        Approved = 1,
        Disapproved = 2,
        Deleted = 3
    }

    public enum StaffStatusEnum
    {
        Active,
        NonActive,
        AgencyStaff,
        OfficeStaff,
        Applicant,
    }
}
