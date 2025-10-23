namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffHealthDataModel
    {
        public int StaffHealthId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }
        public Guid? CompanyId { get; set; }
    }
}