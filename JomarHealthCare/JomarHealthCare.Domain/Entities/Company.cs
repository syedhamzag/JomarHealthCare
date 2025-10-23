namespace JomarHealthCare.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public Company()
        {
            CompanyId = Guid.NewGuid();
        }
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; } = default!;
        public string Address { get; set; }
        public string Website { get; set; }
        public string LogoUrl { get; set; }
        public string Language { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; } = default!;
        public string Country { get; set; }
        public string Currency { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string CurrentCqcRating { get; set; }
        public string CityOfOperation { get; set; }
        public int? AdminmessageId { get; set; }
        public int? AdminAdvertisementId { get; set; }
        public bool IsTrainingModule { get; set; }
        public string OurPhilosophy { get; set; }
        public string Purpose { get; set; }
        public string Complaint { get; set; }
        public string ContactUs { get; set; }
        public string PPE { get; set; }
        public string CompanyCode { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public ICollection<Client> Clients { get; set; } = new List<Client>();
        public ICollection<ClientFacility> Facilities { get; set; } = new List<ClientFacility>();
    }
}
