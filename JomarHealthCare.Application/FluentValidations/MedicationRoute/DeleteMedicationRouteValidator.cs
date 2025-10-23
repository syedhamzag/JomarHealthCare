
using FluentValidation;
using JomarHealthCare.Application.CQRS.MedicationRoutes.Command;

namespace JomarHealthCare.Application.FluentValidations.MedicationRoute
{
    public class DeleteMedicationRouteValidator: AbstractValidator<DeleteMedicationRouteCommand>
    {
        public DeleteMedicationRouteValidator()
        {
            RuleFor(c => c.MedicationRouteId)
         .NotEmpty().WithMessage("RouteId is required.");
        }
    }
}
