namespace JomarHealthCare.Domain.Entities
{
   public class StaffTrainingByList
    {
        public int StaffTrainingId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public string Training { get; set; }
        public string Certificate { get; set; }
        public string Location { get; set; }
        public string Trainer { get; set; }
        public string StartDate { get; set; }
        public string ExpiredDate { get; set; }
        public string CertificateAttachment { get; set; }
        public string TrainingType { get; set; }
        public virtual StaffPersonalInfo Staff { get; set; }
    }
}
