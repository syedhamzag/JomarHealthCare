using FluentValidation;

namespace JomarHealthCare.Application.Validators.HumanResourcesModule
{
    public class CreateAppMessageDataModelValidator : AbstractValidator<CreateAppMessageCommand>
    {
        public CreateAppMessageDataModelValidator()
        {
            RuleFor(x => x.DataModel.Subject)
                .NotEmpty().WithMessage("Subject is required.");

            RuleFor(x => x.DataModel.Message)
                .NotEmpty().WithMessage("Message is required.");

            RuleFor(x => x.DataModel.ToWhom)
                .GreaterThan(0).WithMessage("ToWhom must be greater than 0.");
        }
    }
}
