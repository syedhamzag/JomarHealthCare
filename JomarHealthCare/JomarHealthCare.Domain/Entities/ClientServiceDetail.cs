namespace JomarHealthCare.Domain.Entities
{
  public  class ClientServiceDetail:AuditableEntity,ICompanyEntity
    {
        public ClientServiceDetail()
        {
            ClientServiceDetailReceipts = new HashSet<ClientServiceDetailReceipt>();
            ClientServiceDetailItems = new HashSet<ClientServiceDetailItem>();
        }
        public int ClientServiceDetailId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
       
        public decimal AmountGiven { get; set; }
        public decimal AmountReturned { get; set; }
        public DateTimeOffset ServiceDate { get; set; }

        public virtual ICollection<ClientServiceDetailReceipt> ClientServiceDetailReceipts { get; set; }
        public virtual ICollection<ClientServiceDetailItem> ClientServiceDetailItems { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
