namespace JomarHealthCare.Domain.Entities
{
    public class Investigation : AuditableEntity, ICompanyEntity
    {
        public Investigation()
        {
            InvestigationAttachments = new HashSet<InvestigationAttachment>();
        }
        public int InvestigationId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        /// <summary>
        /// From BaseRecord Item
        /// </summary>
        public int IncidentClass { get; set; }
        public string Remark { get; set; }
        public DateTimeOffset IncidentDate { get; set; }
        public DateTimeOffset? ConclusionDate { get; set; }
        public virtual ICollection<InvestigationAttachment> InvestigationAttachments { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
