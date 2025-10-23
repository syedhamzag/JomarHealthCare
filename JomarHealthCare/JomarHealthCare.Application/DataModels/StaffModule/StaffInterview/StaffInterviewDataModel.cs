using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffInterviewDataModel
    {
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
        public List<StaffInterviewTaskDataModel> StaffInterviewTask { get; set; }
    }
    public class  StaffInterviewTaskDataModel
    {
        public int StaffInterviewTaskId { get; set; }
        public int StaffInterviewId { get; set; }
        public int Title { get; set; }
        public int Answer { get; set; }
        public string Comment { get; set; }
        public int Point { get; set; }
        public int Score { get; set; }
    }
}