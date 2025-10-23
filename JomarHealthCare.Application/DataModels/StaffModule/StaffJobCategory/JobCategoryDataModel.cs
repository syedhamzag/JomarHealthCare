namespace JomarHealthCare.Application.DataModels.StaffModule.StaffJobCategory;

public class JobCategoryDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }
}
