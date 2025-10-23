using FluentValidation;
using JomarHealthCare.Application.CQRS.Client.Commands;

namespace JomarHealthCare.Application.FluentValidations.Client
{
    public class DeleteClientVaidator: AbstractValidator<DeleteClientCommand>
    {
        public DeleteClientVaidator()
        {
            RuleFor(c => c.ClientId)
           .NotEmpty().WithMessage("ClientId is required.");


        }
    }
}
