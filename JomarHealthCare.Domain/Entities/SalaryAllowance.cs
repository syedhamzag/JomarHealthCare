namespace JomarHealthCare.Domain.Entities
{
    public class SalaryAllowance : AuditableEntity,ICompanyEntity
     {
        public int SalaryAllowanceId { get; set; }
        public int AllowanceType { get; set; }
        public string Reoccurent { get; set; }
        public decimal Amount { get; set; }
        public decimal Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
                
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
