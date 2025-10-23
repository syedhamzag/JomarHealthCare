namespace JomarHealthCare.Domain.Entities;

public class ClientSupportPlanGoalAchieve
{
    public int Id { get; set; }
    public int ClientSupportPlanGoalId { get; set; }
    public string DeliveryPlan { get; set; }
    public DateTime? TargetDate { get; set; }
    public DateTime? ReviewDate { get; set; }
    public virtual ClientSupportPlanGoal ClientSupportPlanGoal { get; set; }
}
