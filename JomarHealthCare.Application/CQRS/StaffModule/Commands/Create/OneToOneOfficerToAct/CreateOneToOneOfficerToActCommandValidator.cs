using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateOneToOneOfficerToActCommandValidator : AbstractValidator<CreateOneToOneOfficerToActCommand>
    {
        public CreateOneToOneOfficerToActCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.OneToOneId).GreaterThan(0);
        }
    }
}