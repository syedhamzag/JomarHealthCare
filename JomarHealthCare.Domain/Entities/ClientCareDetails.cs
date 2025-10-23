
namespace JomarHealthCare.Domain.Entities
{
   public class ClientCareDetails: AuditableEntity
    {
        public int ClientCareDetailsId { get; set; }
        public int ClientCareDetailsTaskId { get; set; }
       
        public string Description { get; set; }
        public string Risk { get; set; }
        public string Mitigation { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }


       
        public virtual ClientCareDetailsTask ClientCareDetailsTask { get; set; }
        public Guid? ClientId { get; set; }
        public virtual Client Company { get; set; }
    }
}
