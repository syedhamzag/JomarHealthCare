using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record CreateOfficeAttendanceCommand(OfficeAttendanceDataModel DataModel) : IRequest<OfficeAttendanceDataModel>;
}
