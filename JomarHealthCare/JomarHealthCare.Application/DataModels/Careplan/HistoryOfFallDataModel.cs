namespace JomarHealthCare.Application.DataModels.Careplan;

public class HistoryOfFallDataModel
{
    public int HistoryId { get; set; }

    public string Details { get; set; }
    public DateTime? Date { get; set; }
    public string Cause { get; set; }
    public string Prevention { get; set; }
    public bool IsFallOfRisk { get; set; }
    public string DetailofRisk { get; set; }
    public string CauseAndTriger { get; set; }
    public string HowToControl { get; set; }
    public bool UserAwareOfFall { get; set; }
    public string Escallation { get; set; }
    public Guid? ClientId { get; set; }
}
