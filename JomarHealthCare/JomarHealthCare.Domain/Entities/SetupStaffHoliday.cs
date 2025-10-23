namespace JomarHealthCare.Domain.Entities
{
    public class SetupStaffHoliday : AuditableEntity,ICompanyEntity
    {
        public int SetupHolidayId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public DateTime YearOfEmployment { get; set; }
        public int TypeOfHoliday { get; set; }
        public DateTime YearEndPeriodStartDate { get; set; }
        public int HoursSoFar { get; set; }
        public int IncrementalDailyHolidayByHrs { get; set; }
        public int NumberOfDays { get; set; }
        public string Remark { get; set; }

        public string Attachment { get; set; }

        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
                public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
