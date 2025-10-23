namespace JomarHealthCare.Domain.Entities
{
    public class StaffAlert : AuditableEntity, ICompanyEntity
    {
        public StaffAlert()
        {
            AssignAlertStaff = new HashSet<AssignAlertStaff>();
        }
        public int Id { get; set; }
        public string Heading { get; set; }
        public bool IsSet { get; set; }
        public string Text { get; set; }
        public string TimeDuration { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<AssignAlertStaff> AssignAlertStaff { get; set; }
        public virtual ICollection<StaffAlertCountMatrix> StaffAlertCountMatrix { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
