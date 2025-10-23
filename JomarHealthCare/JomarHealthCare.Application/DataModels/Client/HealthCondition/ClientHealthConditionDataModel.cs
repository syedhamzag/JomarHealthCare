namespace JomarHealthCare.Application.DataModels.Client.HealthCondition;

public class ClientHealthConditionDataModel
{
    public int CHCId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Condition { get; set; }
    public string CausesAndTrigger { get; set; }
    public string Symptoms { get; set; }
    public string ClientManagingWithCondition { get; set; }
    public string RiskToClient { get; set; }
    public string RiskToStaff { get; set; }
    public string ActionRequiredToStaff { get; set; }
    public string EscalationsApproach { get; set; }
    public string Image { get; set; }
    public Guid? ClientId { get; set; }
}
