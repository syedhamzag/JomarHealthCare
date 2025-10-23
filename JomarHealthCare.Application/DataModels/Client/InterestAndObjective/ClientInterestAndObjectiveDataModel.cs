namespace JomarHealthCare.Application.DataModels.Client.InterestObjective;

public class ClientInterestAndObjectiveDataModel
{
    public int GoalId { get; set; }
    public string CareGoal { get; set; }
    public string Brief { get; set; }
    public int? InterestId { get; set; }
    public int? LeisureActivity { get; set; }
    public int? InformalActivity { get; set; }
    public int? MaintainContact { get; set; }
    public int? CommunityActivity { get; set; }
    public int? EventAwarness { get; set; }
    public int? GoalAndObjective { get; set; }

    public Guid? ClientId { get; set; }

    public List<PersonalityTestDataModel> PersonalityTest { get; set; }
}


public class PersonalityTestDataModel
{
    public int TestId { get; set; }
    public int GoalId { get; set; }
    public int Question { get; set; }
    public int Answer { get; set; }
}   