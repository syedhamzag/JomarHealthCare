namespace JomarHealthCare.Domain.Entities
{
    public class StaffBlackList : AuditableEntity
    {
        public int StaffBlackListId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public string Comment { get; set; }
        public DateTime? Date { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }

        public Guid? ClentId { get; set; }
        public virtual Client Client { get; set; }
    }
}
