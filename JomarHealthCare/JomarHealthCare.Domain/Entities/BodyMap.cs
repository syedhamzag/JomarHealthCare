namespace JomarHealthCare.Domain.Entities
{
    public class BodyMap : AuditableEntity
    {
        public int BodyMapId { get; set; }
        public int? StaffRotaPeriodId { get; set; }
        public string CreamName { get; set; }
        public string PurposeOfCream { get; set; }
        public string HowToApply { get; set; }
        public string Instruction { get; set; }
        public string AreaApplied { get; set; }
        public string Escalation { get; set; }
        public DateTime? Date { get; set; }
        public Guid? ClientId { get; set; }
    }
}
