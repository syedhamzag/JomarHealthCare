namespace JomarHealthCare.Domain.Entities
{
  public  class ComplainStaffName
    {
        public int ComplainStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int ComplainId { get; set; }

        public virtual ClientComplainRegister ComplainRegister { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
