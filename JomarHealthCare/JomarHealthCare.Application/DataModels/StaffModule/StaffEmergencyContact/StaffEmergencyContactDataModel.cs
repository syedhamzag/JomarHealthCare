namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffEmergencyContactDataModel
    {
        public int StaffEmergencyContactId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string ContactName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }
    }
}