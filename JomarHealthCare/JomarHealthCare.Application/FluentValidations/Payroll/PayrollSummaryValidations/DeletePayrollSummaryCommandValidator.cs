using FluentValidation;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.FluentValidations.Payroll.PayrollSummaryValidations
{
    public class DeleteRegisterIncomeCommandValidator: AbstractValidator<DeletePayrollSummaryCommand>
    {
        public DeleteRegisterIncomeCommandValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("ID is required.");
        }
    }
}
