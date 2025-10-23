namespace JomarHealthCare.Domain.Entities
{
  public  class EyeHealthStaffName
    {
        public int EyeHealthStaffNameId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }
        public int EyeHealthId { get; set; }

        public virtual ClientEyeHealthMonitoring EyeHealth { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }



    }
}
