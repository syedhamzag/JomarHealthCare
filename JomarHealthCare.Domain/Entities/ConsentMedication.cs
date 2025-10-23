namespace JomarHealthCare.Domain.Entities
{
    public class ConsentMedication
    {
        public int ConsentMedicationId { get; set; }
        public int PersonalDetailId { get; set; }
        public string OwnMedication { get; set; }
        public string FamilyResponsibity { get; set; }
        public string AdministratorProcess { get; set; }
        public virtual PersonalDetail PersonalDetail { get; set; }
    }
}
