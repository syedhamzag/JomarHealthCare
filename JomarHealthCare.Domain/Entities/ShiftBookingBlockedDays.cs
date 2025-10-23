namespace JomarHealthCare.Domain.Entities
{
  public  class ShiftBookingBlockedDays
    {
        public int ShiftBookingBlockedDaysId { get; set; }
        public int ShiftBookingId { get; set; }
        public string Day { get; set; }
        public string WeekDay { get; set; }

        public virtual ShiftBooking ShiftBooking { get; set; }
    }
}
