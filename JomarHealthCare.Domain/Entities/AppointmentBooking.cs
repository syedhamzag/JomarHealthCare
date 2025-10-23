namespace JomarHealthCare.Domain.Entities
{
    public class AppointmentBooking
    {
        public AppointmentBooking()
        {
            Attendee = new HashSet<AppointmentBookingAttendees>();
        }
        public int AppointmentBookingId { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public int Type { get; set; }
        public int Class { get; set; }
        public string AttendeeName { get; set; }
        public Guid CompanyId { get; set; }
        public int Status { get; set; }
        public string Comments { get; set; }
        public virtual ICollection<AppointmentBookingAttendees> Attendee { get; set; }
    }
}
