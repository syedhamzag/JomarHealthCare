using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffInfectionControlCommandValidator : AbstractValidator<CreateStaffInfectionControlCommand>
    {
        public CreateStaffInfectionControlCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffPersonalInfoId).NotEmpty();
            RuleFor(x => x.DataModel.TestDate).NotEmpty();
        }
    }
}