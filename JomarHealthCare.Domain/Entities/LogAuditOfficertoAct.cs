namespace JomarHealthCare.Domain.Entities
{
  public  class LogAuditOfficerToAct
    {
        public int LogAuditOfficerToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int LogAuditId { get; set; }

        public virtual ClientLogAudit LogAudit { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
