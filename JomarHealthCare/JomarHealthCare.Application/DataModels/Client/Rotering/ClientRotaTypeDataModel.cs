namespace JomarHealthCare.Application.DataModels.Client.Rotering;

public class ClientRotaTypeDataModel
{
    public int ClientRotaTypeId { get; set; }
    public string RotaType { get; set; }
    public Guid? CompanyId { get; set; }
}
