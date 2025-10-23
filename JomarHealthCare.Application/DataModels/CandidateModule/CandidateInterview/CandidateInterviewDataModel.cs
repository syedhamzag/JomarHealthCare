using JomarHealthCare.Domain.Enums;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class CandidateInterviewDataModel
    {
        public int Id { get; set; }
        public Guid StaffId { get; set; }
        public int JobPositionId { get; set; }
        public decimal? PassingPercentage { get; set; }
        public decimal? ObtainPercentage { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime? InterviewDate { get; set; }
        public string InterviwerStaff { get; set; }
        public string CandidateSignature { get; set; }
        public InterviewerTypeEnum InterviewType { get; set; }
        public Guid? CompanyId { get; set; }
    }
}