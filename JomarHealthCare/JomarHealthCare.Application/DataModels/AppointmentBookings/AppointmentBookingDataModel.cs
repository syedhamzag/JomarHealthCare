using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.DataModels.AppointmentBookings;

public class AppointmentBookingDataModel
{
    public int AppointmentBookingId { get; set; }
    public DateTime Date { get; set; }
    public string Subject { get; set; }
    public string Location { get; set; }
    public string Link { get; set; }
    public int Type { get; set; }
    public int Class { get; set; }
    public string AttendeeName { get; set; }
    public string CompanyId { get; set; }
    public int Status { get; set; }
    public string Comments { get; set; }
    public List<AppointmentBookingAttendeesDataModel> Attendee { get; set; }
}
public class AppointmentBookingAttendeesDataModel
{
    public int AppointmentBookingAttendeesId { get; set; }
    public string AttendeesId { get; set; }
    public int AppointmentBookingId { get; set; }
}
