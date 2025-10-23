
namespace JomarHealthCare.Domain.Entities
{
    public class StaffInterviewTask : AuditableEntity
    {
        public int StaffInterviewTaskId { get; set; }
        public int StaffInterviewId { get; set; }
        public int Title { get; set; }
        public int Answer { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
        public int Score { get; set; }
        public virtual StaffInterview StaffInterview { get; set; }
    }
}
