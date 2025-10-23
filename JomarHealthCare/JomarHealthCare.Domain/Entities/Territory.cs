namespace JomarHealthCare.Domain.Entities;

public class Territory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid? CompanyId { get; set; }

    public virtual ICollection<Client> Clients { get; set; }
}
