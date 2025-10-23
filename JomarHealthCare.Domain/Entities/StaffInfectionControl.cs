namespace JomarHealthCare.Domain.Entities
{
    public class StaffInfectionControl
    {
        public int InfectionId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public int Type { get; set; }
        public string Guideline { get; set; }
        public DateTime TestDate { get; set; }
        public int VaccStatus { get; set; }
        public string Remarks { get; set; }
        public int Status { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
