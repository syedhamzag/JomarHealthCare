namespace JomarHealthCare.Domain.Entities
{
    public class StaffSpotCheck : AuditableEntity, ICompanyEntity
    {
        public StaffSpotCheck()
        {
            OfficerToAct = new HashSet<SpotCheckOfficerToAct>();
        }
        public int SpotCheckId {get; set;}
        public string Reference { get; set; }
        public Guid StaffId {get; set;}
        public DateTime Date {get; set;}
        public DateTime? NextCheckDate {get; set;}
        public string Details { get; set; }
        public int StaffArriveOnTime {get; set;}
        public int StaffDressCode {get; set;}
        public string AreaComments{get; set;}
        public string ActionRequired{get; set;}
        public DateTime Deadline {get; set;}
        public int Status {get; set;}
        public string Remarks{get; set;}
        public string URL{get; set;}
        public string Attachment {get; set;}
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
       
        public virtual StaffPersonalInfo Staff { get; set; }
        public virtual ICollection<SpotCheckOfficerToAct> OfficerToAct { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
