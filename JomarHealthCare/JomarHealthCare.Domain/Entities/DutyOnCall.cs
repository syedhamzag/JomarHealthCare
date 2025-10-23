namespace JomarHealthCare.Domain.Entities
{
    public class DutyOnCall : AuditableEntity
    {
        public DutyOnCall()
        {
            PersonResponsible = new HashSet<DutyOnCallPersonResponsible>();
            PersonToAct = new HashSet<DutyOnCallPersonToAct>();
        }
        public int DutyOnCallId { get; set; }
        public string RefNo { get; set; }
        public int? TypeOfDutyCall { get; set; }
        public string Subject { get; set; }
        public string ClientInitial { get; set; }
        public DateTime DateOfIncident { get; set; }
        public string ReportedBy { get; set; }
        public string DetailsOfIncident { get; set; }
        public string ActionTaken { get; set; }
        public string DetailsRequired { get; set; }
        public int? Priority { get; set; }
        public int? Status { get; set; }
        public string Remarks { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public virtual ICollection<DutyOnCallPersonResponsible> PersonResponsible { get; set; }
        public virtual ICollection<DutyOnCallPersonToAct> PersonToAct { get; set; }
        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
