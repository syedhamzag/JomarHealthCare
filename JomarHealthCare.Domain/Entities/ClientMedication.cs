using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class ClientMedication : AuditableEntity
    {
        public int ClientMedicationId { get; set; }
        public int? MedicationId { get; set; }
        public int? MedicationManufacturerId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Dossage { get; set; }
        public string Frequency { get; set; }
        public int? Gap_Hour { get; set; }
        public string Route { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StopDate { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string PRNGuideline { get; set; }
        public int? Means { get; set; }
        public int? Type { get; set; }
        public int? TimeCritical { get; set; }
        public int? MedicationRouteId { get; set; }
        public string ClientMedImage { get; set; }
        public bool IsPause { get; set; }
        public bool IsDelete { get; set; }
        public virtual MedicationManufacturer MedicationManufacturer { get; set; }
        public virtual Medication Medication { get; set; }
        public virtual MedicationRoute MedicationRoute { get; set; }
        public virtual ICollection<ClientMedicationDay> ClientMedicationDay { get; set; }
        public Guid? ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
