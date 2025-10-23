namespace JomarHealthCare.Application.DataModels.Staff
{
    public class OneToOneOfficerToActDataModel
    {
        public int OneToOneOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int OneToOneId { get; set; }
    }
}