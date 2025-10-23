namespace JomarHealthCare.Domain.Entities
{
  public  class MedAuditStaffName
    {
        public int MedAuditStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int MedAuditId { get; set; }

        public virtual ClientMedAudit MedAudit { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
