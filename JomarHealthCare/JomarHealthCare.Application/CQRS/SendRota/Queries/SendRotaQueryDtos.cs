using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Queries;

public record GetStaffRotaPreviewQuery(List<RotaPreviewDataModel> data) : IRequest<List<StaffRotaSchedulePreviewDataModel>>;
public record GetStaffMedRotaPreviewQuery(List<RotaPreviewDataModel> data) : IRequest<List<MedTrackerDataModel>>;


public record GetLiveMedicationTracker(GetRotaByDateDataModel data) : IRequest<List<MedTrackerDataModel>>;
public record GetLiveTracker(GetRotaByDateDataModel data) : IRequest<List<LiveTracker>>;
public record GetLiveTrackerConcern(GetRotaByConcernDateDataModel data) : IRequest<List<LiveTracker>>;