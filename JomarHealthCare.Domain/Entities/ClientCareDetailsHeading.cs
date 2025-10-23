
namespace JomarHealthCare.Domain.Entities
{
  public  class ClientCareDetailsHeading: AuditableEntity,ICompanyEntity
    {
        public ClientCareDetailsHeading()
        {
            ClientCareDetailsTasks = new HashSet<ClientCareDetailsTask>();
        }
        public int ClientCareDetailsHeadingId { get; set; }
        public string Heading { get; set; }

        public virtual ICollection<ClientCareDetailsTask> ClientCareDetailsTasks { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
