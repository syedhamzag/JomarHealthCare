namespace JomarHealthCare.Application.DataModels.Careplan;

public class MentalHealthSupportDataModel
{
    public int Id { get; set; }
    public string OftenNeedSupport { get; set; }
    public string StaffPreference { get; set; }
    public bool DayAndTimeSuit { get; set; }
    public string MethodAndApproach { get; set; }
    public string DoesNotWorkAndLike { get; set; }
    public string WiderWorkHealthCare { get; set; }
    public bool SupportPlan { get; set; }
    public bool EligibleSocialCare { get; set; }
    public string ImportantCloseThem { get; set; }
    public string DoneInTheirLive { get; set; }
    public string SomethingEnjoyed { get; set; }
    public bool DoThisAgain { get; set; }
    public string TowardTheirGoals { get; set; }
    public string Keyworker { get; set; }
    public bool PersonNameOrPhoto { get; set; }
    public string StrengthBases { get; set; }
    public Guid? ClientId { get; set; }
}
