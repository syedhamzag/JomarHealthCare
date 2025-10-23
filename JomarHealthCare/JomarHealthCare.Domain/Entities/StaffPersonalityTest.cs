namespace JomarHealthCare.Domain.Entities
{
    public class StaffPersonalityTest
    {
        public int TestId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int Question { get; set; }
        public int Answer { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
