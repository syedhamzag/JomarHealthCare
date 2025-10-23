using MediatR;
using JomarHealthCare.Application.DataModels.SendRota;

namespace JomarHealthCare.Application.CQRS.SendRota.Commands;


public record CreateStaffRotaCommand(List<RotaPreviewDataModel> data) : IRequest<string>;


public record StaffRotaClockInCommand(StaffRotaClockInDto data) : IRequest<string>;
public record StaffRotaClockOutCommand(StaffRotaClockOutDto data) : IRequest<string>;
