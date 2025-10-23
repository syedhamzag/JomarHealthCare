namespace JomarHealthCare.Application.DataModels.Hobby;

public class HobbyDataModel
{
    public int HId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid? CompanyId { get; set; }
}
