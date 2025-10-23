using FluentValidation;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.FluentValidations.PettyCash
{
    public class DeletePayrollSummaryCommandValidator: AbstractValidator<DeletePettyCashCommand>
    {
        public DeletePayrollSummaryCommandValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("ID is required.");
        }
    }
}
