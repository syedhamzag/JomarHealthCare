using FluentValidation;
using JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand;
using JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterIncomeCommand;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.FluentValidations.Payroll.RegisterIncomeValidations
{
    public class AddRegisterIncomeCommandValidator: AbstractValidator<AddRegisterIncomeCommand>
    {
        public AddRegisterIncomeCommandValidator()
        {
            
            RuleFor(c => c.IncomeName)
                .NotEmpty().WithMessage("Income name  is required.");

           
        }
    }
}
