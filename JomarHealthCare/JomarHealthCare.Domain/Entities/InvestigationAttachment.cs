namespace JomarHealthCare.Domain.Entities
{
   public class InvestigationAttachment
    {
        public int InvestigationAttachmentId { get; set; }
        public int InvestigationId { get; set; }
        public string Attachment { get; set; }
        public virtual Investigation Investigation { get; set; }
    }
}
