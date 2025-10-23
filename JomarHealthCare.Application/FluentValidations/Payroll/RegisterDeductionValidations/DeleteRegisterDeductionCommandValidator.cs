using FluentValidation;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterIncomeCommand;
using JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterReductionCommand;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.FluentValidations.Payroll.RegisterDeductionValidations
{
    public class DeleteRegisterDeductionCommandValidator: AbstractValidator<DeleteRegisterReductionCommand>
    {
        public DeleteRegisterDeductionCommandValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("ID is required.");

        }
    }
}
