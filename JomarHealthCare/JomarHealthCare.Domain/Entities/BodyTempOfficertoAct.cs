namespace JomarHealthCare.Domain.Entities
{
  public  class BodyTempOfficerToAct
    {
        public int BodyTempOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BodyTempId { get; set; }

        public virtual ClientBodyTemp BodyTemp { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
