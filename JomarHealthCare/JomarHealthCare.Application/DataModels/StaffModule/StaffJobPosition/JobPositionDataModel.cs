namespace JomarHealthCare.Application.DataModels.StaffModule.StaffJobPosition;

public class JobPositionDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}
