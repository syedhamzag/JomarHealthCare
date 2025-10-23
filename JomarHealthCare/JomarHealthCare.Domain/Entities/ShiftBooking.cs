namespace JomarHealthCare.Domain.Entities
{
   public class ShiftBooking
    {
        public ShiftBooking()
        {
            StaffShiftBooking = new HashSet<StaffShiftBooking>();
            ShiftBookingBlockedDays = new HashSet<ShiftBookingBlockedDays>();
        }
        public int ShiftBookingId { get; set; }
        public string ShiftDate { get; set; }
        public int Rota { get; set; }
        public int NumberOfStaff { get; set; }
        public string StartTime { get; set; }
        public string StopTime { get; set; }
        public string Remark { get; set; }
        /// <summary>
        /// StaffPersonalInfoId
        /// </summary>
        public int Team { get; set; }
        public bool DriverRequired { get; set; }
        public int? PublishTo { get; set; }
        public string CreatedBy { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<StaffShiftBooking> StaffShiftBooking { get; set; }
        public virtual ICollection<ShiftBookingBlockedDays> ShiftBookingBlockedDays { get; set; }
    }
}
