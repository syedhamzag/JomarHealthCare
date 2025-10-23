namespace JomarHealthCare.Application.DataModels.Client.DutyOnCall;

public class DutyOnCallDataModel
{
    public int DutyOnCallId { get; set; }
    public string RefNo { get; set; }
    public int? TypeOfDutyCall { get; set; }
    public string Subject { get; set; }
    public string ClientInitial { get; set; }
    public DateTime DateOfIncident { get; set; }
    public string ReportedBy { get; set; }
    public string DetailsOfIncident { get; set; }
    public string ActionTaken { get; set; }
    public string DetailsRequired { get; set; }
    public int? Priority { get; set; }
    public int? Status { get; set; }
    public string Remarks { get; set; }
    public string Attachment { get; set; }
    public string StaffSignature { get; set; }
    public virtual ICollection<DutyOnCallPersonResponsibleDataModel> PersonResponsible { get; set; }
    public virtual ICollection<DutyOnCallPersonToActDataModel> PersonToAct { get; set; }
    public Guid? ClientId { get; set; }
}


public class DutyOnCallPersonResponsibleDataModel
{
    public int PersonResponsibleId { get; set; }
    public Guid StaffPersonalInfoId { get; set; }
    public int DutyOnCallId { get; set; }
}

public class DutyOnCallPersonToActDataModel
{
    public int PersonToActId { get; set; }
    public Guid StaffPersonalInfoId { get; set; }
    public int DutyOnCallId { get; set; }
}