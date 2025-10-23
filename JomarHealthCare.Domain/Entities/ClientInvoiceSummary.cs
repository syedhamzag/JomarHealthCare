namespace JomarHealthCare.Domain.Entities
{
    public class ClientInvoiceSummary
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Period { get; set; }
        public int ServiceTypeId { get; set; }
        public string CreatedBy { get; set; }
        public virtual ICollection<ClientInvoice> ClientInvoice { get; set; }
    }
}
