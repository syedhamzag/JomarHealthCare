
namespace JomarHealthCare.Domain.Entities;

public class RotaTask
{
    public int RotaTaskId { get; set; }
    public string TaskName { get; set; }
    public string GivenAcronym { get; set; }
    public string NotGivenAcronym { get; set; }
    public string Remark { get; set; }
    public bool Deleted { get; set; }
    public virtual ICollection<ClientRotaTask> ClientRotaTask { get; set; }
    public Guid? CompanyId { get; set; }
}
