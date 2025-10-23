using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Client.Commands
{
    public class CreateStaffSpotCheckCommandValidator : AbstractValidator<CreateStaffSpotCheckCommand>
    {
        public CreateStaffSpotCheckCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffId).NotEmpty();
            RuleFor(x => x.DataModel.Date).NotEmpty();
            RuleFor(x => x.DataModel.Deadline).NotEmpty();
            RuleFor(x => x.DataModel.Status).GreaterThanOrEqualTo(0);
        }
    }
}
