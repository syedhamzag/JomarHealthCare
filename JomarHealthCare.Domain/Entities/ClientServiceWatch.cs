namespace JomarHealthCare.Domain.Entities
{
    public class ClientServiceWatch
    {
        public int WatchId { get; set; }
        public string Reference { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? NextCheckDate { get; set; }
        public int? Incident { get; set; }
        public int? Details { get; set; }
        public int? Contact { get; set; }
        public string Observation { get; set; }
        public string ActionRequired { get; set; }
        public DateTime? Deadline { get; set; }
        public int? Status { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string Attachment { get; set; }
        public bool IsDeleted { get; set; }
        public string PersonToAct { get; set; }
        public string StaffToAct { get; set; }
        public Guid? ClientId { get; set; }
    }
}
