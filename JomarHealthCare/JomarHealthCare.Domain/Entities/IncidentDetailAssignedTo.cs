using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class IncidentDetailAssignedTo
    {
        public int IncidentDetailAssignedToId { get; set; }
        [ForeignKey("StaffPersonalInfo")]
        public Guid StaffPersonalInfoId { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public int IncidentDetailId { get; set; }
        public virtual IncidentDetail IncidentDetail { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
