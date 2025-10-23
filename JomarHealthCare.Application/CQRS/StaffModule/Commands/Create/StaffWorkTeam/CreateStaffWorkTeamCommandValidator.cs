using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffWorkTeamCommandValidator : AbstractValidator<CreateStaffWorkTeamCommand>
    {
        public CreateStaffWorkTeamCommandValidator()
        {
            RuleFor(x => x.DataModel.WorkTeam).NotEmpty();
        }
    }
}