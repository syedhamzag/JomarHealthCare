namespace JomarHealthCare.Domain.Entities
{
   public class StaffShiftBooking
    {
        public StaffShiftBooking()
        {
            Days = new HashSet<StaffShiftBookingDay>();
        }
        public int StaffShiftBookingId { get; set; }
        public int ShiftBookingId { get; set; }
        public Guid StaffPersonalInfoId { get; set; }

        public virtual ShiftBooking ShiftBooking { get; set; }
        public virtual StaffPersonalInfo StaffPersonalInfo { get; set; }
        public virtual ICollection<StaffShiftBookingDay> Days { get; set; }
    }
}
