
namespace JomarHealthCare.Domain.Entities;

public class ClientSupportPlan : AuditableEntity,ICompanyEntity
{
    public int Id { get; set; }
   
    public string MentalHealth { get; set; }
    public string SocialCareNeeds { get; set; }
    public string AccessCommunity { get; set; }
    public string Reltaionship { get; set; }
    public string HabitateHomeEnvironment { get; set; }
    public string PersonalHygiene { get; set; }
    public virtual ICollection<ClientSupportPlanGoal> ClientSupportPlanGoal { get; set; }
    public Guid? CompanyId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Company? Company { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
