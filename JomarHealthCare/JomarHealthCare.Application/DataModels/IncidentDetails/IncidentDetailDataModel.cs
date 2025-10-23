
namespace JomarHealthCare.Application.DataModels.IncidentDetails
{
    public class IncidentDetailDataModel
    {
        public int IncidentDetailId { get; set; }
        public DateTime DateTime { get; set; }
        public bool PoliceNotify { get; set; }
        public string? PoliceNotifyReference { get; set; }
        public string IncidentDetails { get; set; }
        public string IncidentCauses { get; set; }
        public string Recommendations { get; set; }
        public string FollowupAction { get; set; }
        public string IncidentType { get; set; }
        public string Status { get; set; }
        public string CompanyId { get; set; }
        public List<IncidentDetailAssignedToDataModel> AssignedTo { get; set; }
    }
    public class IncidentDetailAssignedToDataModel
    {
        public int IncidentDetailAssignedToId { get; set; }
        public string StaffPersonalInfoId { get; set; }
        public int IncidentDetailId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
