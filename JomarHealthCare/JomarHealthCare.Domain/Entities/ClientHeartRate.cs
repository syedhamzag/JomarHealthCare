namespace JomarHealthCare.Domain.Entities
{
    public class ClientHeartRate : AuditableEntity,ICompanyEntity
    {
        public ClientHeartRate()
        {
            Physician = new HashSet<HeartRatePhysician>();
            StaffName = new HashSet<HeartRateStaffName>();
            OfficerToAct = new HashSet<HeartRateOfficerToAct>();
        }
        public int HeartRateId { get; set; }
        public string Reference { get; set; }
       
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int TargetHR { get; set; }
        public string TargetHRAttach { get; set; }
        public int Gender { get; set; }
        public string GenderAttach { get; set; }
        public int Age { get; set; }
        public int BeatsPerSeconds { get; set; }
        public string Comment { get; set; }
        public int SeeChart { get; set; }
        public string SeeChartAttach { get; set; }
        public string PhysicianResponse { get; set; }
        public DateTime Deadline { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
    
       
        public virtual ICollection<HeartRateOfficerToAct> OfficerToAct { get; set; }
        public virtual ICollection<HeartRateStaffName> StaffName { get; set; }
        public virtual ICollection<HeartRatePhysician> Physician { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }

}
