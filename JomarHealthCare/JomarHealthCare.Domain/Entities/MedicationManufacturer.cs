
namespace JomarHealthCare.Domain.Entities;

public class MedicationManufacturer
{
    public int MedicationManufacturerId { get; set; }
    public string Manufacturer { get; set; }
    public bool Deleted { get; set; }
    public Guid? CompanyId { get; set; }

    public virtual ICollection<ClientMedication> ClientMedications { get; set; }
}
