namespace JomarHealthCare.Domain.Entities
{
    public class StaffTeamLead : AuditableEntity,ICompanyEntity
    {
        public StaffTeamLead()
        {
            StaffTeamLeadTasks = new HashSet<StaffTeamLeadTasks>();
        }
        public int TeamLeadId { get; set; }
        public DateTime Date { get; set; }
        public int Rota { get; set; }
        public Guid ClientInvolved { get; set; }
        public Guid StaffInvolved { get; set; }
        public string DidYouObserved { get; set; }
        public string DidYouDo { get; set; }
        public string OfficeToDo { get; set; }
        public int StaffStoppedWorking { get; set; }

        public virtual ICollection<StaffTeamLeadTasks> StaffTeamLeadTasks { get; set; }
       
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
