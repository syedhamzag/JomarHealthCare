namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffPersonalInfoDataModel
    {
        public Guid StaffPersonalInfoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public bool? IsTeamLeader { get; set; }
        // Add more fields as needed
    }
}