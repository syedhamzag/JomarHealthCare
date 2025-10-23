namespace JomarHealthCare.Domain.Entities
{
    public class HospitalEntry : AuditableEntity
    {
        public int HospitalEntryId { get; set; }
        public string Reference { get; set; }
        public DateTime? DateAndTime { get; set; }
        public string PurposeofAdmission { get; set; }
        public DateTime? LastDateofAdmission { get; set; }
        public int? ConditionOfAdmission { get; set; }
        public int? IsFamilyInformed { get; set; }
        public DateTime? PossibleDateReturn { get; set; }
        public int? IsHomeCleaned { get; set; }
        public int? MeansOfTransport { get; set; }
        public string Attachment { get; set; }
        public string Remark { get; set; }
        public int? Status { get; set; }
        public bool IsDeleted { get; set; }
        public string StaffSignature { get; set; }
        public string StaffInvolved { get; set; }
        public string PersonToTakeAction { get; set; }
        public Guid? ClientId { get; set; }
    }
}
