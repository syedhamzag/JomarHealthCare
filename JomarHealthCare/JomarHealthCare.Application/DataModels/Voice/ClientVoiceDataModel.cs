using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.Voice;

public class ClientVoiceDataModel
{
    public int VoiceId { get; set; }
    public string Reference { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? NextCheckDate { get; set; }
    public int? RateServiceRecieving { get; set; }
    public int? RateStaffAttending { get; set; }
    public int? OfficeStaffSupport { get; set; }
    public string AreasOfImprovements { get; set; }
    public string SomethingSpecial { get; set; }
    public int? InterestedInPrograms { get; set; }
    public string HealthGoalShortTerm { get; set; }
    public string HealthGoalLongTerm { get; set; }
    public string ActionRequired { get; set; }
    public string ActionsTakenByMPCC { get; set; }
    public string EvidenceOfActionTaken { get; set; }
    public int? Status { get; set; }
    public DateTime? Deadline { get; set; }
    public string Remarks { get; set; }
    public string RotCause { get; set; }
    public string LessonLearntAndShared { get; set; }
    public string URL { get; set; }
    public string Attachment { get; set; }
    public bool IsDeleted { get; set; }
    public string OfficerToAct { get; set; }
    public string CallerName { get; set; }
    public string GoodStaff { get; set; }
    public string PoorStaff { get; set; }
    public Guid? ClientId { get; set; }
}
