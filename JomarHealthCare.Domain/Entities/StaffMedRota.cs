using System.ComponentModel.DataAnnotations.Schema;

namespace JomarHealthCare.Domain.Entities
{
    public class StaffMedRota
    {
        public StaffMedRota()
        {
            RotaStaff = new HashSet<RotaStaff>();
        }
        public int StaffRotaId { get; set; }
        public DateTime RotaDate { get; set; }
        public int? RotaDayofWeekId { get; set; }
        public int? RotaId { get; set; }
        public string Remark { get; set; }
        public string ReferenceNumber { get; set; }
        public string DoseGiven { get; set; }
        public string Time { get; set; }
        public string Measurement { get; set; }
        public string Location { get; set; }
        public string Feedback { get; set; }
        public bool ConfirmToGivenRightPerson { get; set; }
        public bool ConfirmToGivenRightPersonTime { get; set; }
        public bool ConfirmRightDoseGiven { get; set; }
        public bool ConfirmMedicationRoute { get; set; }
        public string ClockInLocation { get; set; }
        public string ClockOutLocation { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTimeOffset? ClockInTime { get; set; }
        public DateTimeOffset? ClockOutTime { get; set; }
        public string DosePrescribed { get; set; }
        public string StaffCommentsOrConcern { get; set; }
        public string GivenMedicationNotInChart { get; set; }
        public string Attachment { get; set; }
        public bool Certify { get; set; }
        public virtual Rota Rota { get; set; }
        public virtual ICollection<RotaStaff> RotaStaff { get; set; }
    }
}
