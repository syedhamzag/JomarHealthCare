using JomarHealthCare.Domain.Enums;

namespace JomarHealthCare.Application.DataModels.Staff
{
    public class InterviewQuestionDataModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public bool IsMandatory { get; set; }
        public int JobPosition { get; set; }
        public decimal? Marks { get; set; }
        public decimal? PassingMarks { get; set; }
        public string CreatedBy { get; set; }
        public InterviewerTypeEnum InterviewType { get; set; }
        public Guid? CompanyId { get; set; }
    }
}