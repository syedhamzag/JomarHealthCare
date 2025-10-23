namespace JomarHealthCare.Domain.Entities
{
    public class PettyCashUsage
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime? Date { get; set; }
        public string ReceiptNo { get; set; }
        public string Data { get; set; }
        public decimal? Total { get; set; }
        public int PettyCashId { get; set; }

        public virtual PettyCash PettyCash { get; set; }
    }
}
