namespace JomarHealthCare.Application.DataModels.Client.ClientHobbies;

public class ClientHobbiesDataModel
{
    public int CHId { get; set; }
    public int HId { get; set; }
    public string Name { get; set; }
    public Guid? ClientId { get; set; }
}
