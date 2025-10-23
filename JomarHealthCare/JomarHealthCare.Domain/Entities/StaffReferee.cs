namespace JomarHealthCare.Domain.Entities
{
   public class StaffReferee
    {
        public int StaffRefereeId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Referee { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PositionofReferee { get; set; }
        public string Attachment { get; set; }
        public virtual StaffPersonalInfo Staff { get; set; }
    }
}
