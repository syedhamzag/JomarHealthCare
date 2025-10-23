namespace JomarHealthCare.Domain.Entities
{
  public  class ClientServiceDetailReceipt
    {
        public int ClientServiceDetailReceiptId { get; set; }
        public int ClientServiceDetailId { get; set; }
        public string Attachment { get; set; }

        public virtual ClientServiceDetail ClientServiceDetail { get; set; }
    }
}
