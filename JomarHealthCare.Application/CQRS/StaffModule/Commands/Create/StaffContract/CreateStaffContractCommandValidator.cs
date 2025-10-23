using FluentValidation;

namespace JomarHealthCare.Application.CQRS.Staff.Commands
{
    public class CreateStaffContractCommandValidator : AbstractValidator<CreateStaffContractCommand>
    {
        public CreateStaffContractCommandValidator()
        {
            RuleFor(x => x.DataModel.StaffId).NotEmpty();
            RuleFor(x => x.DataModel.ContactId).GreaterThan(0);
            RuleFor(x => x.DataModel.Template).NotEmpty();
        }
    }
}