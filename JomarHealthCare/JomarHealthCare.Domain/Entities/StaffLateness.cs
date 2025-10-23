namespace JomarHealthCare.Domain.Entities
{
    public class StaffLateness : AuditableEntity,ICompanyEntity
    {
        public int StaffLatenessId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int SN { get; set; }
        public DateTime Date { get; set; }
        public int Rota { get; set; }
        public DateTime TimeCritical { get; set; }
        public string Reason { get; set; }
        public string Response { get; set; }
        public int Status { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
