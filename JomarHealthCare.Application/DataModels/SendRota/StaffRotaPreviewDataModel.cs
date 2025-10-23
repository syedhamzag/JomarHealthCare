using System.Globalization;

namespace JomarHealthCare.Application.DataModels.SendRota;


public class StaffRotaSchedulePreviewDataModel
{
    public DateTime? RotaDate { get; set; }
    public List<StaffRotaPreviewDataModel> StaffRotaPreview { get; set; }

}

public class StaffRotaPreviewDataModel
{
    public int ClientRotaId { get; set; }
    public Guid? ClientId { get; set; }
    public string Period { get; set; }
    public string ClientName { get; set; }
    public string ClientKeySafe { get; set; }
    public string ClientPostCode { get; set; }
    public string DayofWeek { get; set; }
    public string StartTime { get; set; }
    public DateTime? RotaStartTime { get; set; }
    public string StopTime { get; set; }
    public DateTimeOffset? ClockInTime { get; set; }
    public DateTimeOffset? ClockOutTime { get; set; }
    public string Rota { get; set; }
    public string Staff { get; set; }
    public DateTime RotaDate { get; set; }
    public string Remark { get; set; }
    public string ReferenceNumber { get; set; }
    public List<StaffPartner> Partners { get; set; }
}


public class StaffPartner
{
    public string Partner { get; set; }
    public string Telephone { get; set; }
}

public class RotaPreviewDataModel
{
    public DateTime RotaDate { get; set; }
    public int RotaId { get; set; }
    public int? RotaDayofWeekId { get; set; }
    public List<string> RotaTypes { get; set; }
    public List<Guid> StaffList { get; set; }
    public Guid? CompanyId { get; set; }
    public string Remarks { get; set; }
}


public class GetClientAttachedToRota
{
    public int ClientRotaId { get; set; }
    public Guid? ClientId { get; set; }
    public int ClientRotaTypeId { get; set; }
    public int ClientRotaDaysId { get; set; }
    public int? RotaDayofWeekId { get; set; }
    public int? RotaId { get; set; }
}


public class GetRotaByDateDataModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid? CompanyId { get; set; }
}
public class GetRotaByConcernDateDataModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid? CompanyId { get; set; }
    public string? ClientId { get; set; }
    public string? StaffPersonalInfoId { get; set; }
    public int ReportedConcernId { get; set; }
}

public class StaffRotaClockInDto
{
    public int StaffRotaPeriodId { get; set; }
    public string GeoLocation { get; set; }
    public string CheckInMode { get; set; }
}

public class StaffRotaClockOutDto
{
    public int StaffRotaPeriodId { get; set; }
    public string GeoLocation { get; set; }
    public string CheckInMode { get; set; }
}

public class LiveTracker
{
    public LiveTracker()
    {
        TaskPerformed = new List<string>();
    }
    public int ClientRotaId { get; set; }
    public int StaffRotaId { get; set; }
    public int? JobPositionId { get; set; }
    public string JobPositionName { get; set; }
    public int StaffRotaPeriodId { get; set; }
    public int ClientRotaDaysId { get; set; }
    public Guid? ClientId { get; set; }
    public string Period { get; set; }
    public int? PeriodId { get; set; }
    public string CompanyLogo { get; set; }
    public string CompanyName { get; set; }
    public string ClientName { get; set; }
    public string ClientKeySafe { get; set; }
    public string ClientPostCode { get; set; }
    public string ClientTelephone { get; set; }
    public string ClientProviderReference { get; set; }
    public string ClientIdNumber { get; set; }
    public string ClientLatitude { get; set; }
    public string ClientLongitude { get; set; }
    public decimal ClientRate { get; set; }
    public int? NumberOfStaff { get; set; }
    public int AreaCode { get; set; }
    public string DayofWeek { get; set; }
    public string StartTime { get; set; }
    public string StopTime { get; set; }
    public DateTimeOffset? ClockInTime { get; set; }
    public DateTimeOffset? ClockOutTime { get; set; }
    public string ClockInStart { get; set; }
    public string ClockOutEnd { get; set; }
    public TimeSpan? ClockDiff { get; set; }
    public string ClockInMethod { get; set; }
    public string ClockOutMethod { get; set; }
    public string Feedback { get; set; }
    public string Rota { get; set; }
    public string Staff { get; set; }
    public string StaffTelephone { get; set; }
    public decimal? StaffRate { get; set; }
    public DateTime RotaDate { get; set; }
    public string RotaDateOnly { get; set; }
    public string Remark { get; set; }
    public string ReferenceNumber { get; set; }
    public List<string> TaskPerformed { get; set; }
    public string ClockInAddress { get; set; }
    public string ClockOutAddress { get; set; }
    public string ClockInGeolocation { get; set; }
    public string ClockOutGeolocation { get; set; }
    public string ClockInClientTelephone { get; set; }
    public string ClockOutClientTelephone { get; set; }
    public string ClockInDistance { get; set; }
    public string ClockOutDistance { get; set; }
    public int? ClockInCount { get; set; }
    public int? ClockOutCount { get; set; }
    public string Comment { get; set; }
    public string LatenessComment { get; set; }
    public bool? OtherTask { get; set; }
    public bool? ObjectiveOfCareMeet { get; set; }
    public bool? ClientHappyWithServiceOrStaff { get; set; }
    public bool? Certify { get; set; }
    public bool? NotifyManager { get; set; }
    public bool? RaseConcern { get; set; }
    public string HandOver { get; set; }
    public string BowelMovement { get; set; }
    public string OralCare { get; set; }
    public string FluidIntake { get; set; }
    public string MealIntake { get; set; }
    public string BodyMap { get; set; }
    public string forcedExit { get; set; }
    public string AlertComment { get; set; }

    public int? TimeMonitorLower { get; set; }
    public int? TimeMonitorHigher { get; set; }
    public string RowClass(string startTime, DateTimeOffset? clockInTime)
    {
        try
        {
            //var st = TimeSpan.TryParseExact("6:15", "h\\:mm", CultureInfo.CurrentCulture, TimeSpanStyles.None, out d) ? d : default(TimeSpan);
            //var ct = TimeSpan.TryParseExact("06:15:00", "hh\\:mm\\:ss", CultureInfo.CurrentCulture, TimeSpanStyles.None, out c) ? c : default(TimeSpan);
            //var df = st.Subtract(ct);

            string rowColor = "gray";
            if (clockInTime.HasValue)
            {
                var st = TimeSpan.TryParseExact(startTime, "h\\:mm", CultureInfo.CurrentCulture, TimeSpanStyles.None, out TimeSpan d) ? d : default(TimeSpan);
                var ct = TimeSpan.TryParseExact(clockInTime.Value.AddHours(1).DateTime.TimeOfDay.ToString(), "hh\\:mm\\:ss", CultureInfo.CurrentCulture, TimeSpanStyles.None, out TimeSpan c) ? c : default(TimeSpan);
                var df = st.Subtract(ct).TotalMinutes;

                if (df <= 15 && df >= -15)
                {
                    rowColor = "green";//green
                }
                else if (df > 15 && df <= 30)
                {
                    rowColor = "gray";

                }
                else if (df >= -30)
                {
                    rowColor = "yellow";
                }
                else
                {
                    rowColor = "red";// "#f2dede";//red
                }


            }
            else
            {
                rowColor = "#f2dede";
            }

            return rowColor;//missed;
        }
        catch (Exception)
        {
            return "gray";

        }
    }
 
    public int? clientRotaTypeId { get; set; }
    
    public string AuditRemarks { get; set; }
    public string ActionRecommendation { get; set; }
    public string EvidenceOfActionTaken { get; set; }
    public string AuditStatus { get; set; }
    public string NameOfAuditor { get; set; }
    public string GapObserve { get; set; }
    public DateTime? DateOfAudit { get; set; }
    public bool? EmailAuditToClient { get; set; }
    public bool? EmailAuditToStaff { get; set; }
    public bool? ConcernWithStaff { get; set; }
    public bool? ConcertWithClient { get; set; }
    public int? logAuditTrackerId { get; set; }
    public Guid StaffId { get; set; }

    public string forcedEntry { get; set; }
    public string reasonExceeding { get; set; }
    public string Signature { get; set; }
    public string Address { get; set; }
    public string StaffRole { get; set; }
    public string UpcomingplannedTask { get; set; }
    public TimeSpan? GapObserveTime { get; set; }
    public string Response { get; set; }
}