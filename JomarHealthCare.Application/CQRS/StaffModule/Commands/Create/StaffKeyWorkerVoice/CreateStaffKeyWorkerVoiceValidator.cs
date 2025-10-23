using FluentValidation;
using JomarHealthCare.Application.DataModels.Staff;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffKeyWorkerVoiceValidator : AbstractValidator<StaffKeyWorkerVoiceDataModel>
    {
        public CreateStaffKeyWorkerVoiceValidator()
        {
            RuleFor(x => x.StaffId).NotEmpty();
            RuleFor(x => x.Date).NotEmpty();
            RuleFor(x => x.Deadline).NotEmpty();
            RuleFor(x => x.Status).GreaterThanOrEqualTo(0);
        }
    }
}