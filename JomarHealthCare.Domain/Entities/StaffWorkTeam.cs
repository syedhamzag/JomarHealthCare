namespace JomarHealthCare.Domain.Entities
{
    public class StaffWorkTeam
    {
        public StaffWorkTeam()
        {
            StaffPersonalInfo = new HashSet<StaffPersonalInfo>();
        }
        public int StaffWorkTeamId { get; set; }
        public string WorkTeam { get; set; }
        public string CreatedBy { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<StaffPersonalInfo> StaffPersonalInfo { get; set; }
    }
}
