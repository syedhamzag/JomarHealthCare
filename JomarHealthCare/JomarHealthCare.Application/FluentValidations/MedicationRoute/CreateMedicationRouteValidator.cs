using FluentValidation;
using JomarHealthCare.Application.CQRS.MedicationRoutes.Command;

namespace JomarHealthCare.Application.FluentValidations.MedicationRoute
{
    public class CreateMedicationRouteValidator: AbstractValidator<CreateMedicationRouteCommand>
    {
        public CreateMedicationRouteValidator()
        {
            RuleFor(c => c.RouteName)
            .NotEmpty().WithMessage("Route name is required.")
            .MaximumLength(100);
        }
    }
}
