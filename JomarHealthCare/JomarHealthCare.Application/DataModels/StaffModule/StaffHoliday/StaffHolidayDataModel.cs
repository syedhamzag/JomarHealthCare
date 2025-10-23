namespace JomarHealthCare.Application.DataModels.Staff
{
    public class StaffHolidayDataModel
    {
        public int StaffHolidayId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public decimal YearOfService { get; set; }
        public decimal AllocatedDays { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Days { get; set; }
        public string Purpose { get; set; }
        public int Class { get; set; }
        public string PersonOnResponsibility { get; set; }
        public string CopyOfHandover { get; set; }
        public string Remark { get; set; }
        public string Attachment { get; set; }
        public string Status { get; set; }
        public Guid? CompanyId { get; set; }
    }
}