namespace JomarHealthCare.Application.DataModels.Client.Program;

public class ClientProgramDataModel
{
    public int ProgramId { get; set; }
    public string Reference { get; set; }
    public DateTime? Date { get; set; }
    public DateTime? NextCheckDate { get; set; }
    public int? ProgramOfChoice { get; set; }
    public int? DaysOfChoice { get; set; }
    public int? PlaceLocationProgram { get; set; }
    public int? DetailsOfProgram { get; set; }
    public string Observation { get; set; }
    public string ActionRequired { get; set; }
    public DateTime? Deadline { get; set; }
    public int? Status { get; set; }
    public string Remarks { get; set; }
    public string URL { get; set; }
    public string Attachment { get; set; }
    public Guid? ClientId { get; set; }

    public string OfficerToAct { get; set; }
}