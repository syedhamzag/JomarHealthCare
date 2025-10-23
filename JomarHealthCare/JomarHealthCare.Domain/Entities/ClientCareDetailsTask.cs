
namespace JomarHealthCare.Domain.Entities
{
  public  class ClientCareDetailsTask: AuditableEntity,ICompanyEntity
    {
        public ClientCareDetailsTask()
        {
            ClientCareDetails = new HashSet<ClientCareDetails>();
        }
        public int ClientCareDetailsTaskId { get; set; }
        public int ClientCareDetailsHeadingId { get; set; }
        public string Task { get; set; }

        public virtual ClientCareDetailsHeading ClientCareDetailsHeading { get; set; }
        public ICollection<ClientCareDetails> ClientCareDetails { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
