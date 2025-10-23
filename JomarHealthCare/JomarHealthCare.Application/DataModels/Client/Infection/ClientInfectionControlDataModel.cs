namespace JomarHealthCare.Application.DataModels.Client.Infection;

public class ClientInfectionControlDataModel
{
    public int InfectionId { get; set; }

    public int? Type { get; set; }

    public string Detail { get; set; }
    public string Guideline { get; set; }
    public DateTime? TestDate { get; set; }
    public int? VaccStatus { get; set; }
    public string Remarks { get; set; }
    public int? Status { get; set; }
    public Guid? ClientId { get; set; }
}
