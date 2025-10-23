using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffShadowingCommandValidator : AbstractValidator<CreateStaffShadowingCommand>
    {
        public CreateStaffShadowingCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.Heading).NotEmpty();
        }
    }
}