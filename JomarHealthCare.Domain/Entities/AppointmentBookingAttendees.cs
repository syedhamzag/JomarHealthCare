namespace JomarHealthCare.Domain.Entities
{
    public  class AppointmentBookingAttendees
    {
        public int AppointmentBookingAttendeesId { get; set; }
        public Guid AttendeesId { get; set; }
        public int AppointmentBookingId { get; set; }


        public virtual AppointmentBooking AppointmentBooking { get; set; }
    }
}
