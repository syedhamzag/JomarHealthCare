
namespace JomarHealthCare.Application.DataModels.ReportedConcerns
{
    public class ReportedConcernDataModel
    {
        public int ReportedConcernId { get; set; }
        public string ReportedConcernType { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
