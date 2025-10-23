using MediatR;
using JomarHealthCare.Application.DataModels.HumanResourcesModule;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public record UpdateOfficeAttendanceCommand(OfficeAttendanceDataModel DataModel) : IRequest<bool>;
}
