
namespace JomarHealthCare.Domain.Entities
{
    public class StaffInterview : AuditableEntity
    {
        public StaffInterview()
        {
            StaffInterviewTask = new HashSet<StaffInterviewTask>();
        }
        public int StaffInterviewId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Heading { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }
        public DateTime InterviewDate { get; set; }
        public string JobPosition { get; set; }
        public int PassingMarks { get; set; }
        public int ObtainMarks { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public virtual ICollection<StaffInterviewTask> StaffInterviewTask { get; set; }
    }
}
