namespace JomarHealthCare.Domain.Entities
{
    public class EquipmentAssessmentData
    {
        public int Id { get; set; }
        public int EquipmentAssessmentId { get; set; }
        public string URL { get; set; }
        public string HowToUse { get; set; }
        public string ClientRisk { get; set; }
        public string StaffRisk { get; set; }
        public string Image { get; set; }
    }
}
