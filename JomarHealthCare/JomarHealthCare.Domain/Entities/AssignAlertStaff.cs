namespace JomarHealthCare.Domain.Entities
{
    public class AssignAlertStaff : AuditableEntity, ICompanyEntity
    {
        public int Id { get; set; }
        public int StaffAlertId { get; set; }
        public bool Deleted { get; set; }
        public Guid StaffId { get; set; }
        public StaffAlert StaffAlert { get; set; }
        public StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
