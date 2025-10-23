namespace JomarHealthCare.Domain.Entities
{
    public class DutyOnCallPersonToAct
    {
        public int PersonToActId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int DutyOnCallId { get; set; }

        public virtual DutyOnCall DutyOnCall { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
