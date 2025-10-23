namespace JomarHealthCare.Domain.Entities;

public class AreaCode
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }

    public virtual ICollection<Client> Clients { get; set; }

}
