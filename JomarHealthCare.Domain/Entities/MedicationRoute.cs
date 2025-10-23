namespace JomarHealthCare.Domain.Entities;

public class MedicationRoute
{
    public int MedicationRoutId { get; set; }
    public string RouteName { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<ClientMedication> ClientMedications { get; set; }
    public Guid? CompanyId { get; set; }
}
