namespace JomarHealthCare.Application.DataModels.ServiceType;

public class ServiceTypeDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}
