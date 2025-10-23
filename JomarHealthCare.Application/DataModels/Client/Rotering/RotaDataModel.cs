namespace JomarHealthCare.Application.DataModels.Client.Rotering;

public class RotaDataModel
{
    public int RotaId { get; set; }
    public int NumberOfStaff { get; set; }
    public string RotaName { get; set; }
    public string Gender { get; set; }
    public string Area { get; set; }
    public Guid? CompanyId { get; set; }
}
