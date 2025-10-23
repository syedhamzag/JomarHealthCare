namespace JomarHealthCare.Application.DataModels.Careplan;

public class PersonalDataModel
{
    public int PersonalId { get; set; }
    public Guid ClientId { get; set; }
    public string Religion { get; set; }
    public string Nationality { get; set; }
    public int Smoking { get; set; }
    public int DNR { get; set; }
}
