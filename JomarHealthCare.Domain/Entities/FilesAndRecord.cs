namespace JomarHealthCare.Domain.Entities
{
    public class FilesAndRecord : AuditableEntity,ICompanyEntity
    {   
        public int FilesAndRecordId { get; set; }
        public DateTime Date { get; set; }
        public int? ClientId { get; set; }
        public string Subject { get; set; }
        public Guid StaffPersonalInfoId{ get; set; }
        public string Remarks { get; set; }
        public string Attachment { get; set; }
        public FilesAndRecordEnum Type { get; set; }
        public string FileName { get; set; }
        public string FileFormat { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
       
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
