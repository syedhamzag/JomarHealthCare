namespace JomarHealthCare.Domain.Entities
{
    public class IncidentDetail
    {
        public IncidentDetail()
        {
            AssignedTo = new HashSet<IncidentDetailAssignedTo>();
        }
        public int IncidentDetailId { get; set; }
        public DateTime DateTime { get; set; }
        public bool PoliceNotify { get; set; }
        public string? PoliceNotifyReference { get; set; }
        public string IncidentDetails { get; set; }
        public string IncidentCauses { get; set; }
        public string Recommendations { get; set; }
        public string FollowupAction { get; set; }
        public string IncidentType {get; set;}
        public string Status { get; set; }
        public Guid CompanyId { get; set; }
        public virtual ICollection<IncidentDetailAssignedTo> AssignedTo { get; set; }
    }
}
