using MediatR;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public record CreateStaffSupervisionAppraisalCommand(StaffSupervisionAppraisalDataModel DataModel) : IRequest<StaffSupervisionAppraisalDataModel>;
}
