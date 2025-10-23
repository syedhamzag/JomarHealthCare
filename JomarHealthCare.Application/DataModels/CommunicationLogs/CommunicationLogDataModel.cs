using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.CommunicationLogs;

public class CommunicationLogDataModel
{
    public int CommunicationLogId { get; set; }
    public string MeetingTitle { get; set; }
    public DateTime Date { get; set; }
    public TimeOnly Time { get; set; }
    public string MinuteTaker { get; set; }
    public string ClinicalPresentation { get; set; }
    public string Discussion { get; set; }
    
    public string Plan { get; set; }
    public string ActionItems { get; set; }
    public string CaseNo { get; set; }
    public int Status { get; set; }
    public string AttendeeName { get; set; }
    public string ApologiesName { get; set; }
    public string CompanyId { get; set; }
    public List<CommunicationLogAttendeesDataModel> Attendee { get; set; }
    public List<CommunicationLogApologiesDataModel> Apologies { get; set; }

}
public class CommunicationLogAttendeesDataModel
{
    public int CommunicationLogAttendeesId { get; set; }
    public string AttendeesId { get; set; }
    public int CommunicationLogId { get; set; }
}
public class CommunicationLogApologiesDataModel
{
    public int CommunicationLogApologiesId { get; set; }
    public string ApologiesId { get; set; }
    public int CommunicationLogId { get; set; }
}
