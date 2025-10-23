namespace JomarHealthCare.Domain.Entities
{
  public  class BMIChartStaffName
    {
        public int BMIChartStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int BMIChartId { get; set; }

        public virtual ClientBMIChart BMIChart { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
    }
}
