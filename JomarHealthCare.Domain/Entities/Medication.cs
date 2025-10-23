
namespace JomarHealthCare.Domain.Entities;

public class Medication
{
    public int MedicationId { get; set; }
    public string MedicationName { get; set; }
    public string Strength { get; set; }
    public string Indication { get; set; }
    public Guid? CreatedBy { get; set; }
    public bool Deleted { get; set; }

    public virtual ICollection<ClientMedication> ClientMedications { get; set; }
}
