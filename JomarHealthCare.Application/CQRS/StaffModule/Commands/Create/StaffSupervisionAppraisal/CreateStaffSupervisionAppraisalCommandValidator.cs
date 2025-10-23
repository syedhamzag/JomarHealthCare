using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class CreateStaffSupervisionAppraisalCommandValidator : AbstractValidator<CreateStaffSupervisionAppraisalCommand>
    {
        public CreateStaffSupervisionAppraisalCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffId).NotEmpty();
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.Deadline).NotEmpty();
            RuleFor(x => x.DataModel.Status).NotEmpty();
        }
    }
}
