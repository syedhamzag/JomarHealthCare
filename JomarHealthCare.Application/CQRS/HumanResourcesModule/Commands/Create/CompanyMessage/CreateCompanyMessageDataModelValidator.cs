using FluentValidation;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class CreateCompanyMessageDataModelValidator : AbstractValidator<CreateCompanyMessageCommand>
    {
        public CreateCompanyMessageDataModelValidator()
        {
            RuleFor(x => x.DataModel.CompanysMessage)
                .NotEmpty().WithMessage("Company's message is required.");

            RuleFor(x => x.DataModel.CreatedBy)
                .NotEmpty().WithMessage("CreatedBy is required.");
        }
    }
}
