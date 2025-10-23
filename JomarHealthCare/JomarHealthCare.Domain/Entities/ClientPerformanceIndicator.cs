namespace JomarHealthCare.Domain.Entities
{
    public class ClientPerformanceIndicator : AuditableEntity , ICompanyEntity
    {
        public int PerformanceIndicatorId { get; set; }
       
        public string Heading { get; set; }

        public DateTime Date { get; set; }

        public DateTime DueDate { get; set; }

        public int Rating { get; set; }
        public string Remarks { get; set; }
        public string StaffSignature { get; set; }
        public string ManagerSignature { get; set; }
        public string ClientSignature { get; set; }

        public virtual ICollection<ClientPerformanceIndicatorTask> ClientPerformanceIndicatorTask { get; set; } = new HashSet<ClientPerformanceIndicatorTask>();
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
