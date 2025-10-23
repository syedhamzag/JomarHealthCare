namespace JomarHealthCare.Domain.Entities
{
    public class ClientInvoice
    {
        public int Id { get; set; }

        public DateTime? InvoiceDate { get; set; }
        public long InvoiceNo { get; set; }
        public string InvoiceNoWithMonth { get; set; }
        public string BillTo { get; set; }
        public int? TypeOfService { get; set; }
        public string PeriodType { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Charges { get; set; }
        public decimal? Total { get; set; }
        public int ClientInvoiceSummaryId { get; set; }
        public int? ClienBillToId { get; set; }
        public virtual ICollection<ClientInvoiceRecords> ClientInvoiceRecords { get; set; }
        public virtual ClientInvoiceSummary ClientInvoiceSummary { get; set; }
        public Guid? ClientId { get; set; }
    }
}
