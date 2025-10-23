namespace JomarHealthCare.Domain.Entities
{
    public class ClientBloodPressure : AuditableEntity, ICompanyEntity
    {
        public ClientBloodPressure()
        {
            Physician = new HashSet<BloodPressurePhysician>();
            StaffName = new HashSet<BloodPressureStaffName>();
            OfficerToAct = new HashSet<BloodPressureOfficerToAct>();
        }
        public string Reference { get; set; }
        public int BloodPressureId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int GoalSystolic { get; set; }
        public int GoalDiastolic { get; set; }
        public int ReadingSystolic { get; set; }
        public int ReadingDiastolic { get; set; }
        public int StatusImage { get; set; }
        public string Comment { get; set; }
        public string StatusAttach { get; set; }
        public string PhysicianResponse { get; set; }
        public DateTime Deadline { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }

        public virtual ICollection<BloodPressureOfficerToAct> OfficerToAct { get; set; }
        public virtual ICollection<BloodPressureStaffName> StaffName { get; set; }
        public virtual ICollection<BloodPressurePhysician> Physician { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }

}
