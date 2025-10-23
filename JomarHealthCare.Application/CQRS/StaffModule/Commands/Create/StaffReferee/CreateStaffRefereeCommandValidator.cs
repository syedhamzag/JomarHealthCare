using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{




















    public class CreateStaffRefereeCommandValidator : AbstractValidator<CreateStaffRefereeCommand>
    {
        public CreateStaffRefereeCommandValidator()
        {
            RuleFor(x => x.DataModel.Referee).NotEmpty();
            RuleFor(x => x.DataModel.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.DataModel.PhoneNumber).NotEmpty();
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
        }
    }
}