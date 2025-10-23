using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffHolidayCommandValidator : AbstractValidator<CreateStaffHolidayCommand>
    {
        public CreateStaffHolidayCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.StartDate).NotEmpty();
            RuleFor(x => x.DataModel.EndDate).GreaterThanOrEqualTo(x => x.DataModel.StartDate);
            RuleFor(x => x.DataModel.Status).NotEmpty();
        }
    }
}