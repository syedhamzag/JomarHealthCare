namespace JomarHealthCare.Domain.Entities;

public class ClientSupportPlanGoal
{
    public int Id { get; set; }
    public int ClientSupportPlanId { get; set; }
    public string Goal { get; set; }
    public string Important { get; set; }
    public string Help { get; set; }
    public string Success { get; set; }

    public virtual ClientSupportPlan ClientSupportPlan { get; set; }
    public virtual ICollection<ClientSupportPlanGoalAchieve> ClientSupportPlanGoalAchieve { get; set; }
}
