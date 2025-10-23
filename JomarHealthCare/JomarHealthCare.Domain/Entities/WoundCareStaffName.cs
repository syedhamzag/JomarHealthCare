namespace JomarHealthCare.Domain.Entities
{
  public  class WoundCareStaffName
    {
        public int WoundCareStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int WoundCareId { get; set; }

        public virtual ClientWoundCare WoundCare { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}