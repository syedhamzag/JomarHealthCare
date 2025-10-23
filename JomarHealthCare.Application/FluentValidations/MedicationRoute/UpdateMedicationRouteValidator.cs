using FluentValidation;
using JomarHealthCare.Application.CQRS.MedicationRoutes.Command;

namespace JomarHealthCare.Application.FluentValidations.MedicationRoute
{
    public class UpdateMedicationRouteValidator: AbstractValidator<UpdateMedicationRouteCommand>
    {
        public UpdateMedicationRouteValidator()
        {
            RuleFor(c => c.MedicationRouteId)
         .NotEmpty().WithMessage("MedicationRouteId is required.");


            RuleFor(c => c.RouteName)
               .NotEmpty().WithMessage("Route name required")
               .MaximumLength(100);
        }
    }
}
