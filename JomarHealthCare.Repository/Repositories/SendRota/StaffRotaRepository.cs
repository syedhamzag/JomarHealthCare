using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using JomarHealthCare.Application;
using JomarHealthCare.Application.Configs;
using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Application.Repositories;
using JomarHealthCare.Application.Repositories.SendRota;
using JomarHealthCare.Domain.Entities;
using JomarHealthCare.Domain.Entities.Map;
using JomarHealthCare.Domain.Enums;
using JomarHealthCare.Repository.Database;
using JomarHealthCare.Repository.Repositories.Clients.Rotering;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace JomarHealthCare.Repository.Repositories.SendRota;

public class StaffRotaRepository : GenericRepository<StaffRota>, IStaffRotaRepository
{
    private readonly MyCareDbContext _context;
    public StaffRotaRepository(IUnitOfWork dbContext, MyCareDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<string> ClockIn(StaffRotaClockInDto request)
    {
        var rota = await _context.Set<StaffRotaPeriod>()
            .FirstOrDefaultAsync(x => x.StaffRotaPeriodId == request.StaffRotaPeriodId);

        if (rota == null)
            return "Not Found";

        string clockInMode = "";
        string clockInAddress = "";
        string clockInDistance = "";
        if (string.IsNullOrEmpty(request.CheckInMode) || request.CheckInMode.Equals("ScanCode", StringComparison.OrdinalIgnoreCase) || request.CheckInMode.Equals("Startwatch", StringComparison.OrdinalIgnoreCase))
        {
            if (rota.ClientId.HasValue)
            {
                var correctLocation = await IsLocationValid(rota.ClientId.Value, request.GeoLocation);
                if (!correctLocation.IsValid)
                {
                    rota.ClockInAddress = correctLocation.Address;
                    rota.ClockInDistance = "Not within a 30-meter range";
                    rota.ClockInCount = rota.ClockInCount ?? 0 + 1;

                    await _context.SaveChangesAsync();
                    return $"You are clocking in from a wrong location, {rota.ClockInAddress}";
                }
                clockInAddress = correctLocation.Address;
                clockInDistance = "Within a 30-meter range";
            }
            clockInMode = request.CheckInMode.Equals("ScanCode") ? ClockModeEnum.ScanCode.ToString() : ClockModeEnum.Startwatch.ToString();
        }
        else
        {
            clockInMode = ClockModeEnum.RFID.ToString();
        }
        rota.ClockInTime = DateTimeOffset.Now;
        rota.ClockInGeolocation = request.GeoLocation;
        rota.ClockInAddress = clockInAddress;
        rota.ClockInDistance = clockInDistance;
        rota.ClockInCount = rota.ClockInCount ?? 0 + 1;
        await _context.SaveChangesAsync();
        // Your further logic here...
        return "Clock-in successful";
    }

    public async Task<string> ClockOut(StaffRotaClockOutDto request)
    {
        var rota = await _context.Set<StaffRotaPeriod>()
            .FirstOrDefaultAsync(x => x.StaffRotaPeriodId == request.StaffRotaPeriodId);

        if (rota == null)
            return "Not Found";

        string clockInMode = "";
        string clockOutAddress = "";
        string clockOutDistance = "";
        if (string.IsNullOrEmpty(request.CheckInMode) || request.CheckInMode.Equals("ScanCode", StringComparison.OrdinalIgnoreCase) || request.CheckInMode.Equals("Startwatch", StringComparison.OrdinalIgnoreCase))
        {
            if (rota.ClientId.HasValue)
            {
                var correctLocation = await IsLocationValid(rota.ClientId.Value, request.GeoLocation);
                if (!correctLocation.IsValid)
                {
                    rota.ClockOutAddress = correctLocation.Address;
                    rota.ClockOutDistance = "Not within a 30-meter range";
                    rota.ClockOutCount = rota.ClockOutCount ?? 0 + 1;

                    await _context.SaveChangesAsync();
                    return $"You are clocking out from a wrong location, {rota.ClockOutAddress}";
                }
                clockOutAddress = correctLocation.Address;
                clockOutDistance = "Within a 30-meter range";
            }
            clockInMode = request.CheckInMode.Equals("ScanCode") ? ClockModeEnum.ScanCode.ToString() : ClockModeEnum.Startwatch.ToString();
        }
        else
        {
            clockInMode = ClockModeEnum.RFID.ToString();
        }
        rota.ClockOutTime = DateTimeOffset.Now;
        rota.ClockOutMode = clockInMode;
        rota.ClockOutGeolocation = request.GeoLocation;
        rota.ClockOutAddress = clockOutAddress;
        rota.ClockOutDistance = clockOutDistance;
        rota.ClockOutCount = rota.ClockOutCount ?? 0 + 1;

        await _context.SaveChangesAsync();
        // Your further logic here...
        return "Clock-out successful";
    }


    public async Task<(bool IsValid, string? Address)> IsLocationValid(Guid clientId, string staffGeolocation)
    {
        var client = await _context.Set<Client>().FirstOrDefaultAsync(x => x.ClientId == clientId);
        if (client == null || string.IsNullOrWhiteSpace(staffGeolocation))
            return (false, null);

        var staffGeo = staffGeolocation.Split(';');
        if (staffGeo.Length < 2)
            return (false, null);

        if (!double.TryParse(staffGeo[0], out var staffLat) || !double.TryParse(staffGeo[1], out var staffLng))
            return (false, null);

        if (!double.TryParse(client.Latitude, out var clientLat) || !double.TryParse(client.Longitude, out var clientLng))
            return (false, null);

        var isValid = GeoLocationHelper.IsWithin30Meters(staffLat, staffLng, clientLat, clientLng);

        // 🏠 Get full address from coordinates
        var address = await GeoLocationHelper.GetFullAddressFromCoordinates(staffLat, staffLng);

        return (isValid, address);
    }


    public async Task<string> CreateStaffRota(List<RotaPreviewDataModel> request)
    {
        foreach (var model in request)
        {

            foreach (var item in model.StaffList)
            {
                var rota = new StaffRota();
                rota.RotaId = model.RotaId;
                rota.RotaDayofWeekId = model.RotaDayofWeekId;
                rota.RotaDate = model.RotaDate;
                rota.Staff = item;
                rota.Remark = model.Remarks;
                rota.ReferenceNumber = DateTime.Now.ToString("yyyyMMddhhmmssms") + model.StaffList.IndexOf(item);
                foreach (var rp in model.RotaTypes)
                {
                    ClientRotaType rotaType;

                    // If rota type is one of the default ones
                    if (rp == "AM" || rp == "LUNCH" || rp == "TEA" || rp == "BED")
                    {
                        rotaType = await _context.Set<ClientRotaType>()
                            .FirstOrDefaultAsync(x => x.RotaType == rp);
                    }
                    else
                    {
                        rotaType = await _context.Set<ClientRotaType>()
                            .FirstOrDefaultAsync(x => x.RotaType == rp && x.CompanyId == model.CompanyId);
                    }

                    if (rotaType == null)
                        continue;
                    var data = await GetAttachedClientByRotaId(model.RotaId, model.RotaDayofWeekId, rotaType.ClientRotaTypeId);
                    if (data != null && data.Count > 0)
                    {
                        foreach (var rotaClient in data)
                        {
                            rota.StaffRotaPeriods.Add(new StaffRotaPeriod
                            {
                                ClientRotaTypeId = rotaType.ClientRotaTypeId,
                                ClientId = rotaClient.ClientId
                            });
                        }
                    }
                }

                var partner = model.StaffList.Where(x => !x.Equals(item)).ToList();
                if (partner.Count() > 0)
                {
                    foreach (var partnerId in partner)
                    {
                        rota.StaffRotaPartners.Add(new StaffRotaPartner
                        {
                            StaffId = partnerId
                        });
                    }
                }
                await _context.Set<StaffRota>().AddAsync(rota);
                await _context.SaveChangesAsync();
            }


            StaffMedRota med = new StaffMedRota();
            med.RotaDate = model.RotaDate;
            med.RotaDayofWeekId = model.RotaDayofWeekId;
            med.RotaId = model.RotaId;
            med.Remark = model.Remarks;
            med.ReferenceNumber = DateTime.Now.ToString("yyyyMMddhhmmssms") + model.RotaId;
            med.DoseGiven = string.Empty;
            med.Time = string.Empty;
            med.Measurement = string.Empty;
            med.Location = string.Empty;
            med.Feedback = string.Empty;
            med.Certify = true;
            med.ConfirmToGivenRightPerson = true;
            med.ConfirmRightDoseGiven = true;
            med.ConfirmToGivenRightPersonTime = true;
            med.CompanyId = model.CompanyId;
            foreach (var staff in model.StaffList)
            {
                med.RotaStaff.Add(new RotaStaff
                {
                    StaffId = staff
                });
            }

            await _context.Set<StaffMedRota>().AddAsync(med);
            await _context.SaveChangesAsync();
        }

        return "Staff Rota Created Successfully";
    }

    public List<LiveTracker> LiveTracker(GetRotaByDateDataModel request)
    {
        if (request.StartDate == null || request.EndDate == null)
            return new List<LiveTracker>();

        // Fix for CS1061: Replace usage of 'crd.ClientRotaTypeId' and 'crd.ClientId' with correct navigation property access.
        // In the LiveTracker method, update the join condition and select statement as follows:

        var rotas = (from sr in _context.Set<StaffRota>()
                     join srp in _context.Set<StaffRotaPeriod>() on sr.StaffRotaId equals srp.StaffRotaId
                     join crd in _context.Set<ClientRotaDays>() on new { key1 = srp.ClientRotaTypeId, key2 = srp.ClientId }
                         equals new { key1 = crd.ClientRota.ClientRotaTypeId, key2 = crd.ClientRota.ClientId }
                     join c in _context.Set<Client>() on srp.ClientId equals c.ClientId
                     join st in _context.Set<StaffPersonalInfo>() on sr.Staff equals st.StaffPersonalInfoId
                     join crt in _context.Set<ClientRotaType>() on srp.ClientRotaTypeId equals crt.ClientRotaTypeId
                     join r in _context.Set<Rota>() on sr.RotaId equals r.RotaId
                     join rtwd in _context.Set<RotaDayofWeek>() on crd.RotaDayofWeekId equals rtwd.RotaDayofWeekId
                     where sr.RotaDate.Date >= request.StartDate.Date &&
                     sr.RotaDate.Date <= request.EndDate.Date
                     select new LiveTracker
                     {
                         AreaCode = c.AreaCodeId ?? 0,
                         ClientRotaId = crd.ClientRotaId,
                         ClientId = srp.ClientId,
                         ClientIdNumber = c.IdNumber,
                         ClientLatitude = c.Latitude,
                         ClientLongitude = c.Longitude,
                         ClientProviderReference = c.ProviderReference,
                         Period = crt.RotaType,
                         PeriodId = crt.ClientRotaTypeId,
                         ClientName = c.Firstname + " " + c.Middlename + " " + c.Surname,
                         ClientPostCode = c.Address + " / " + c.PostCode,
                         RotaDate = sr.RotaDate,
                         DayofWeek = rtwd.DayofWeek,
                         StartTime = crd.StartTime,
                         StopTime = crd.StopTime,
                         ClockInTime = srp.ClockInTime,
                         ClockOutTime = srp.ClockOutTime,
                         Rota = r.RotaName,
                         Staff = st.FirstName + " " + st.LastName,
                         Remark = sr.Remark,
                         ReferenceNumber = sr.ReferenceNumber,
                         ClientKeySafe = c.KeySafe,
                         ClientRate = c.Rate ?? 0,
                         StaffId = st.StaffPersonalInfoId,
                         ClientTelephone = c.Telephone,
                         ClockInMethod = srp.ClockInMode,
                         ClockOutMethod = srp.ClockOutMode,
                         Feedback = srp.Feedback,
                         HandOver = srp.HandOver,
                         Comment = srp.Comment,
                         ClockInAddress = srp.ClockInAddress,
                         ClockInGeolocation = srp.ClockInGeolocation,
                         ClockOutAddress = srp.ClockOutAddress,
                         ClockOutGeolocation = srp.ClockOutGeolocation,
                         ClockOutClientTelephone = srp.ClockOutClientTelephone,
                         ClockInClientTelephone = srp.ClockInClientTelephone,
                         NumberOfStaff = c.NumberOfStaff,
                         StaffTelephone = st.Telephone,
                         StaffRate = st.Rate,
                         ClientRotaDaysId = crd.ClientRotaDaysId,
                         StaffRotaId = sr.StaffRotaId,
                         StaffRotaPeriodId = srp.StaffRotaPeriodId,
                         BowelMovement = srp.BowelMovement,
                         OralCare = srp.OralCare,
                         FluidIntake = srp.FluidIntake,
                         OtherTask = srp.OtherTask,
                         ObjectiveOfCareMeet = srp.ObjectiveOfCareMeet,
                         ClientHappyWithServiceOrStaff = srp.ClientHappyWithServiceOrStaff,
                         Certify = srp.Certify,
                         NotifyManager = srp.NotifyManager,
                         RaseConcern = srp.RaseConcern,
                         MealIntake = srp.MealIntake,
                         BodyMap = srp.BodyMap,
                         ClockInCount = srp.ClockInCount,
                         ClockOutCount = srp.ClockOutCount,
                         ClockOutDistance = srp.ClockOutDistance,
                         ClockInDistance = srp.ClockInDistance,
                         forcedEntry = srp.forcedEntry,
                         forcedExit = srp.forcedExit,
                         Signature = srp.Signature,
                         reasonExceeding = srp.reasonExceeding,
                         UpcomingplannedTask = srp.UpcomingplannedTask,
                     }).AsNoTracking().OrderBy(o => o.RotaDate).ToList();

        var distinctRotas = rotas.Distinct(new LiveTrackerEqualityComparer()).ToList();
        return distinctRotas;
    }

    public List<MedTrackerDataModel> MedicationLiveTracker(GetRotaByDateDataModel request)
    {
        if (request.StartDate == null || request.EndDate == null)
            return new List<MedTrackerDataModel>();
        List<MedTrackerDataModel> model = new List<MedTrackerDataModel>();
        for (DateTime date = request.StartDate; date <= request.EndDate; date = date.AddDays(1))
        {
            int dayId = WeekofDay.GetDayID(date.ToString("dddd"));
            var tracker = (from smt in _context.Set<StaffMedRota>()
                           join period in _context.Set<ClientMedicationPeriod>() on smt.RotaId equals period.RotaId
                           join day in _context.Set<ClientMedicationDay>() on period.ClientMedicationDayId equals day.ClientMedicationDayId
                           join med in _context.Set<ClientMedication>().Where(x => !x.IsDelete) on day.ClientMedicationId equals med.ClientMedicationId
                           join cl in _context.Set<Client>() on med.ClientId equals cl.ClientId
                           where cl.CompanyId == request.CompanyId
                           join crt in _context.Set<ClientRotaType>() on period.ClientRotaTypeId equals crt.ClientRotaTypeId
                           join r in _context.Set<Rota>() on smt.RotaId equals r.RotaId
                           join rs in _context.Set<RotaStaff>() on smt.StaffRotaId equals rs.StaffMedRotaId
                           where smt.RotaDate == date && day.RotaDayofWeekId == dayId
                           select new MedTrackerDataModel
                           {
                               RotaDate = smt.RotaDate,
                               RotaName = r.RotaName,
                               ClientId = med.ClientId,
                               ClientIdNumber = cl.IdNumber,
                               ClientMedicationId = med.ClientMedicationId,
                               ClientMedImage = med.ClientMedImage,
                               ClientName = string.Concat(cl.Firstname, cl.Middlename, cl.Surname),
                               DOB = cl.DateOfBirth,
                               Dossage = med.Dossage,
                               ExpiryDate = med.ExpiryDate,
                               Frequency = med.Frequency,
                               Gap_Hour = med.Gap_Hour,
                               Means = med.Means,
                               Medication = med.Medication.MedicationName,
                               Strength = med.Medication.Strength,
                               MedicationId = med.MedicationId,
                               MedicationManufacturer = med.MedicationManufacturer.Manufacturer,
                               MedicationManufacturerId = med.MedicationManufacturerId,
                               PERIOD = crt.RotaType,
                               Remark = med.Remark,
                               StartDate = period.StartTime,
                               StopDate = period.StopTime,
                               TimeCritical = med.TimeCritical,
                               Route = med.Route,
                               Status = med.Status,
                               Type = med.Type,
                               DoseGiven = smt.DoseGiven,
                               Time = smt.Time,
                               Location = smt.Location,
                               Measurement = smt.Measurement,
                               Feedback = smt.Feedback,
                               NoOfStaff = cl.NumberOfStaff,
                               SName = (from rs in _context.Set<RotaStaff>().Where(x => x.StaffMedRotaId == smt.StaffRotaId)
                                        join st in _context.Set<StaffPersonalInfo>() on rs.StaffId equals st.StaffPersonalInfoId
                                        select new StaffName
                                        {
                                            Name = string.Concat(st.FirstName, st.LastName)
                                        }
                                        ).ToList(),
                               ClientMedicationPeriodId = period.ClientMedicationPeriodId,
                               StaffRotaId = smt.StaffRotaId,
                               RotaDayofWeekId = day.RotaDayofWeekId,
                               UpdateMedicationPeriod = (from rs in _context.Set<ClientMedicationAdditional>().Where(x => x.ClientMedicationPeriodId == period.ClientMedicationPeriodId)
                                                         select new GetClientMedicationAdditional
                                                         {
                                                             DoseGiven = rs.DoseGiven,
                                                             DoseTobeGiven = rs.DoseTobeGiven,
                                                             RotaDate = rs.RotaDate,
                                                             ClientMedicationPeriodId = rs.ClientMedicationPeriodId,
                                                             FeedBack = rs.FeedBack,
                                                             Time = rs.Time,
                                                             Instruction = rs.Instruction,
                                                             StopTime = rs.StopTime,
                                                             Status = rs.Status
                                                         }
                                        ).ToList(),
                           }).OrderBy(o => o.ClientId).ToList();
            model.AddRange(tracker);
        }

        return model;
    }

    public List<MedTrackerDataModel> SendRotaMedicationPreview(List<RotaPreviewDataModel> request)
    {
        List<MedTrackerDataModel> collection = new List<MedTrackerDataModel>();
        foreach (var input in request)
        {
            var tracker = (from period in _context.Set<ClientMedicationPeriod>().Where(x => x.RotaId == input.RotaId)
                           join day in _context.Set<ClientMedicationDay>().Where(x => x.RotaDayofWeekId == input.RotaDayofWeekId) on period.ClientMedicationDayId equals day.ClientMedicationDayId
                           join med in _context.Set<ClientMedication>().Where(x => !x.IsDelete) on day.ClientMedicationId equals med.ClientMedicationId
                           join cl in _context.Set<Client>().Where(x => input.CompanyId != null ? x.CompanyId == input.CompanyId : x.CompanyId == null) on med.ClientId equals cl.ClientId
                           join crt in _context.Set<ClientRotaType>() on period.ClientRotaTypeId equals crt.ClientRotaTypeId
                           join r in _context.Set<Rota>() on period.RotaId equals r.RotaId
                           select new MedTrackerDataModel
                           {
                               RotaDate = input.RotaDate,
                               RotaName = r.RotaName,
                               ClientId = med.ClientId,
                               ClientIdNumber = cl.IdNumber,
                               ClientMedicationId = med.ClientMedicationId,
                               ClientMedImage = med.ClientMedImage,
                               ClientName = string.Concat(cl.Firstname, cl.Middlename, cl.Surname),
                               DOB = cl.DateOfBirth,
                               Dossage = med.Dossage,
                               ExpiryDate = med.ExpiryDate,
                               Frequency = med.Frequency,
                               Gap_Hour = med.Gap_Hour,
                               Means = med.Means,
                               Medication = med.Medication.MedicationName,
                               MedicationId = med.MedicationId,
                               MedicationManufacturer = med.MedicationManufacturer.Manufacturer,
                               MedicationManufacturerId = med.MedicationManufacturerId,
                               PERIOD = crt.RotaType,
                               Remark = med.Remark,
                               StartDate = period.StartTime,
                               StopDate = period.StopTime,
                               TimeCritical = med.TimeCritical,
                               Route = med.Route,
                               Status = med.Status,
                               Type = med.Type
                           }).OrderBy(o => o.ClientId).ToList();

            collection.AddRange(tracker);
        }
        return collection;
    }

    public List<StaffRotaSchedulePreviewDataModel> SendRotaPreview(List<RotaPreviewDataModel> request)
    {
        List<StaffRotaSchedulePreviewDataModel> collection = new List<StaffRotaSchedulePreviewDataModel>();
        foreach (var model in request)
        {
            StaffRotaSchedulePreviewDataModel data = new StaffRotaSchedulePreviewDataModel();
            data.RotaDate = model.RotaDate;
            data.StaffRotaPreview = (from crd in _context.Set<ClientRotaDays>().Where(x => x.RotaId == model.RotaId && x.RotaDayofWeekId == model.RotaDayofWeekId)
                                     join rd in _context.Set<RotaDayofWeek>() on crd.RotaDayofWeekId equals rd.RotaDayofWeekId
                                     join r in _context.Set<Rota>() on crd.RotaId equals r.RotaId
                                     join cr in _context.Set<ClientRota>() on crd.ClientRotaId equals cr.ClientRotaId
                                     join crt in _context.Set<ClientRotaType>().Where(x => model.RotaTypes.Contains(x.RotaType)) on cr.ClientRotaTypeId equals crt.ClientRotaTypeId
                                     join c in _context.Set<Client>() on cr.ClientId equals c.ClientId
                                     select new StaffRotaPreviewDataModel
                                     {
                                         ClientRotaId = cr.ClientRotaId,
                                         ClientId = cr.ClientId,
                                         Period = crt.RotaType,
                                         ClientName = c.Firstname + " " + c.Middlename + " " + c.Surname,
                                         ClientPostCode = c.PostCode,
                                         RotaDate = model.RotaDate,
                                         DayofWeek = rd.DayofWeek,
                                         StartTime = crd.StartTime,
                                         StopTime = crd.StopTime,
                                         RotaStartTime = Convert.ToDateTime(crd.StartTime),
                                         Rota = r.RotaName
                                     }).AsNoTracking().OrderByDescending(x => x.RotaDate).ToList();
            collection.Add(data);
        }
        return collection;
    }

    public List<LiveTracker> LiveTrackerByConcern(GetRotaByConcernDateDataModel request)
    {
        if (request.StartDate == null || request.EndDate == null)
            return new List<LiveTracker>();

        // Fix for CS1061: Replace usage of 'crd.ClientRotaTypeId' and 'crd.ClientId' with correct navigation property access.
        // In the LiveTracker method, update the join condition and select statement as follows:

        var rotas = (from sr in _context.Set<StaffRota>()
                     join srp in _context.Set<StaffRotaPeriod>() on sr.StaffRotaId equals srp.StaffRotaId
                     join crd in _context.Set<ClientRotaDays>() on new { key1 = srp.ClientRotaTypeId, key2 = srp.ClientId }
                         equals new { key1 = crd.ClientRota.ClientRotaTypeId, key2 = crd.ClientRota.ClientId }
                     join c in _context.Set<Client>() on srp.ClientId equals c.ClientId
                     join st in _context.Set<StaffPersonalInfo>() on sr.Staff equals st.StaffPersonalInfoId
                     join crt in _context.Set<ClientRotaType>() on srp.ClientRotaTypeId equals crt.ClientRotaTypeId
                     join r in _context.Set<Rota>() on sr.RotaId equals r.RotaId
                     join rtwd in _context.Set<RotaDayofWeek>() on crd.RotaDayofWeekId equals rtwd.RotaDayofWeekId
                     where sr.RotaDate.Date >= request.StartDate.Date &&
                     sr.RotaDate.Date <= request.EndDate.Date && (string.IsNullOrEmpty(request.ClientId) ? true : srp.ClientId.ToString() == request.ClientId)
                        && (string.IsNullOrEmpty(request.StaffPersonalInfoId) ? true : sr.Staff.ToString() == request.StaffPersonalInfoId)
                        && (request.CompanyId == null ? true : r.CompanyId == request.CompanyId)
                        //&& (request.ReportedConcernId == 0 ? true : srp.ReportedConcernId == request.ReportedConcernId)

                     select new LiveTracker
                     {
                         RotaDate = sr.RotaDate,
                         Rota = r.RotaName,
                         StaffId = st.StaffPersonalInfoId,
                         Staff = st.FirstName + " " + st.LastName,
                         StaffTelephone = st.Telephone,
                         ClientId = srp.ClientId,
                         ClientName = c.Firstname + " " + c.Middlename + " " + c.Surname,
                         ClientTelephone = c.Telephone,
                         RaseConcern = srp.RaseConcern,
                     }).AsNoTracking().OrderBy(o => o.RotaDate).ToList();

        var distinctRotas = rotas.Distinct(new LiveTrackerEqualityComparer()).ToList();
        return distinctRotas;
    }

    private async Task<List<GetClientAttachedToRota>> GetAttachedClientByRotaId(int rotaId, int? rotaDayOfWeekId, int clientRotaTypeId)
    {
        var clientByRota = await (from cl in _context.Set<ClientRota>()
                                  join cld in _context.Set<ClientRotaDays>() on cl.ClientRotaId equals cld.ClientRotaId
                                  where cld.RotaId == rotaId && cld.RotaDayofWeekId == rotaDayOfWeekId && cl.ClientRotaTypeId == clientRotaTypeId
                                  select new GetClientAttachedToRota
                                  {
                                      ClientRotaId = cl.ClientRotaId,
                                      ClientId = cl.ClientId,
                                      ClientRotaTypeId = cl.ClientRotaTypeId,
                                      RotaId = cld.RotaId,
                                      RotaDayofWeekId = cld.RotaDayofWeekId,
                                      ClientRotaDaysId = cld.ClientRotaDaysId
                                  }).AsNoTracking().ToListAsync();

        return clientByRota;
    }

    private class LiveTrackerEqualityComparer : EqualityComparer<LiveTracker>
    {
        public override bool Equals([AllowNull] LiveTracker x, [AllowNull] LiveTracker y)
        {
            if (x == null && y == null) return true;

            if (x == null || y == null) return false;

            if ((x.Period == y.Period) && (x.StaffRotaPeriodId == y.StaffRotaPeriodId)) return true;

            return false;
        }

        public override int GetHashCode([DisallowNull] LiveTracker obj)
        {
            var hashCode = obj.StaffRotaPeriodId;

            return hashCode.GetHashCode();
        }
    }
}
