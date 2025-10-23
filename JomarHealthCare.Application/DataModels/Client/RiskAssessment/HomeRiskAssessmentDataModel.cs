namespace JomarHealthCare.Application.DataModels.Client.RiskAssessment;

public class HomeRiskAssessmentDataModel
{
    public int HomeRiskAssessmentId { get; set; }
    public int? HeadingId { get; set; }
    public Guid? ClientId { get; set; }
    public List<HomeRiskAssessmentDataItemModel> HomeRiskAssessmentTask { get; set; }
}


public class HomeRiskAssessmentDataItemModel
{
    public int HomeRiskAssessmentTaskId { get; set; }
    public int HomeRiskAssessmentId { get; set; }
    public int Title { get; set; }
    public int Answer { get; set; }
    public string Comment { get; set; }
}