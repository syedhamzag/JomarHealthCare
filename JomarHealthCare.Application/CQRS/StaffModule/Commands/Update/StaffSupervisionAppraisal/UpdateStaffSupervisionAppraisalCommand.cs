using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public record UpdateStaffSupervisionAppraisalCommand(StaffSupervisionAppraisalDataModel DataModel) : IRequest<bool>;
}
