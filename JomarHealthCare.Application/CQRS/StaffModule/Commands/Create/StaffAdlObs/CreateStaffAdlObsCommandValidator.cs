using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffAdlObsCommandValidator : AbstractValidator<CreateStaffAdlObsCommand>
    {
        public CreateStaffAdlObsCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffId).NotEmpty();
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.ActionRequired).NotEmpty();
            RuleFor(x => x.DataModel.Deadline).NotEmpty();
        }
    }

}