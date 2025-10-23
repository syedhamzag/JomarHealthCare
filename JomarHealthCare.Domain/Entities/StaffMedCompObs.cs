using System.ComponentModel.DataAnnotations;

namespace JomarHealthCare.Domain.Entities
{
    public class StaffMedComp : AuditableEntity, ICompanyEntity
    {
        public StaffMedComp()
        {
            OfficerToAct = new HashSet<MedCompOfficerToAct>();
        }
        [Key]
        public int MedCompId { get; set; }
        public string Reference { get; set; }
        public Guid StaffId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? NextCheckDate { get; set; }
        public string Details { get; set; }
       
        public int UnderstandingofMedication { get; set; }
        public int UnderstandingofRights { get; set; }
        public int ReadingMedicalPrescriptions { get; set; }
        public int CarePlan { get; set; }
        public int RateStaff { get; set; }
        public string ActionRequired { get; set; }
        public DateTime Deadline { get; set; }
        public int Status { get; set; }
        public string Remarks { get; set; }
        public string URL { get; set; }
        public string Attachment { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
       
        public virtual StaffPersonalInfo Staff { get; set; }
        public virtual ICollection<MedCompOfficerToAct> OfficerToAct { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
