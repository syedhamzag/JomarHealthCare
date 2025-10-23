using JomarHealthCare.Application.DataModels.SendRota;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.Application.Repositories.SendRota;

public interface IStaffRotaRepository : IGenericRepository<StaffRota>
{
    List<StaffRotaSchedulePreviewDataModel> SendRotaPreview(List<RotaPreviewDataModel> request);

    List<MedTrackerDataModel> SendRotaMedicationPreview(List<RotaPreviewDataModel> request);

    Task<string> CreateStaffRota(List<RotaPreviewDataModel> request);


    List<MedTrackerDataModel> MedicationLiveTracker(GetRotaByDateDataModel request);

    List<LiveTracker> LiveTracker(GetRotaByDateDataModel request);
    List<LiveTracker> LiveTrackerByConcern(GetRotaByConcernDateDataModel request);

    Task<string> ClockIn(StaffRotaClockInDto request);

    Task<string> ClockOut(StaffRotaClockOutDto request);
}
