namespace JomarHealthCare.Domain.Entities
{
    public class ClientRegulatoryContact : AuditableEntity
    {
        public int ClientRegulatoryContactId { get; set; }

        public int BaseRecordItemId { get; set; }
        public DateTime? DatePerformed { get; set; }
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// Link to attachement
        /// </summary>
        public string Evidence { get; set; }


        public virtual BaseRecordItemModel BaseRecordItem { get; set; }

        public Guid? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
