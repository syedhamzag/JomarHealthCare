namespace JomarHealthCare.Domain.Entities
{
  public  class OneToOneOfficerToAct
    {
        public int OneToOneOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int OneToOneId { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
