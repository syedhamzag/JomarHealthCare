using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public record CreateStaffInfectionControlCommand(StaffInfectionControlDataModel DataModel) : IRequest<StaffInfectionControlDataModel>;
}