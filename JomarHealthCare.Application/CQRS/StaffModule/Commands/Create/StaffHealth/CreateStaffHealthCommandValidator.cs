using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffHealthCommandValidator : AbstractValidator<CreateStaffHealthCommand>
    {
        public CreateStaffHealthCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.Heading).NotEmpty().MaximumLength(255);
        }
    }
}