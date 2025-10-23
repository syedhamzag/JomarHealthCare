namespace JomarHealthCare.Domain.Entities
{
    public class CreateShift : AuditableEntity,ICompanyEntity
    {
        public CreateShift()
        {
            CreateShiftRoles = new HashSet<CreateShiftRoles>();
        }
        public int Id { get; set; }
        public string RoleAndNumber { get; set; }
        public bool IsFreeAccomodation { get; set; }
        public string RatePerHour { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set;}
        //public DateTime StartTime { get; set; }
        //public DateTime EndTime { get; set; }
        public virtual ICollection<CreateShiftRoles> CreateShiftRoles { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
