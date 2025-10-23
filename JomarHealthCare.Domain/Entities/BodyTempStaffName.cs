namespace JomarHealthCare.Domain.Entities
{
  public  class BodyTempStaffName
    {
        public int BodyTempStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BodyTempId { get; set; }

        public virtual ClientBodyTemp BodyTemp { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
