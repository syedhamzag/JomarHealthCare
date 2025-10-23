namespace JomarHealthCare.Domain.Entities
{
    public class ClientInvoiceRecords
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Number { get; set; }
        public string Notes { get; set; }
        public int ClientInvoiceId { get; set; }
        public virtual ClientInvoice ClientInvoice { get; set; }
    }
}
