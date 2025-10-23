namespace JomarHealthCare.Domain.Entities
{
    public class CreateShiftRoles : AuditableEntity, ICompanyEntity
    {
        public int Id { get; set; }
        public int ShiftId { get; set; }
        public int ClientFacilityId { get; set; }

        public Guid StaffId { get; set; }
        public int StaffJobCategory { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndtTime { get; set; }
        public bool IsBook { get; set; }
        public StaffPersonalInfo StaffUser { get; set; }
        public CreateShift CreateShift { get; set; }
        public ClientFacility ClientFacility { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
