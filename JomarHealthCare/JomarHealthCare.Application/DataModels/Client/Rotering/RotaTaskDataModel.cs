namespace JomarHealthCare.Application.DataModels.Client.Rotering;

public class RotaTaskDataModel
{
    public int RotaTaskId { get; set; }
    public string TaskName { get; set; }
    public string GivenAcronym { get; set; }
    public string NotGivenAcronym { get; set; }
    public string Remark { get; set; }
    public Guid? CompanyId { get; set; }
}
