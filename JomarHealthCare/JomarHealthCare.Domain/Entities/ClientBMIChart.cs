namespace JomarHealthCare.Domain.Entities
{
    public class ClientBMIChart:AuditableEntity,ICompanyEntity
    {
        public ClientBMIChart()
        {
            Physician = new HashSet<BMIChartPhysician>();
            StaffName = new HashSet<BMIChartStaffName>();
            OfficerToAct = new HashSet<BMIChartOfficerToAct>();
        }
        public int BMIChartId { get; set; }
        public string Reference { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Height { get; set; }
        public string Weight { get; set; }
        public int NumberRange { get; set; }
        public int SeeChart { get; set; }
        public string SeeChartAttach { get; set; }
        public string Comment { get; set; }
        public string PhysicianResponse { get; set; }
        public DateTime Deadline { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }
    
        public virtual ICollection<BMIChartOfficerToAct> OfficerToAct { get; set; }
        public virtual ICollection<BMIChartStaffName> StaffName { get; set; }
        public virtual ICollection<BMIChartPhysician> Physician { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }

}
