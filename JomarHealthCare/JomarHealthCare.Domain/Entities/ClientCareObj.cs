namespace JomarHealthCare.Domain.Entities
{
    public class ClientCareObj: AuditableEntity,ICompanyEntity
    {
        public int CareObjId { get; set; }
        public DateTime Date { get; set; }
       
        public string Note { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }

       
        public virtual ICollection<CareObjPersonToAct> PersonToAct { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
