namespace JomarHealthCare.Domain.Entities
{
    public class ClientFacility : AuditableEntity,ICompanyEntity
    {
        public ClientFacility()
        {
            CreateShiftRoles = new HashSet<CreateShiftRoles>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public BusinessCategory BusinessType { get; set; }
        public string FacilityManagerName { get; set; }
        public string FacilityManagerEmail { get; set; }
        public string FacilityManagerPhoneNumber { get; set; }
        public int NumberOfRooms { get; set; }
        public string FacilityType { get; set; }
        public string Description { get; set; }
        public string Profile { get; set; }
        public string ServiceObjective { get; set; }
        public string AccessCodeNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int GenderId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public string IdNumber { get; set; }
        public string AboutClient { get; set; }
        public decimal? HourRate { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<CreateShiftRoles> CreateShiftRoles { get; set; }
        public virtual ICollection<ClientFacilityRisk> ClientFacilityRisk { get; set; }
        public virtual ICollection<ClientFacilityTask> ClientFacilityTasks { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
