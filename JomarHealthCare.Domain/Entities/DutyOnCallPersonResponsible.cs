namespace JomarHealthCare.Domain.Entities
{
    public class DutyOnCallPersonResponsible
    {
        public int PersonResponsibleId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int DutyOnCallId { get; set; }

        public virtual DutyOnCall DutyOnCall { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
