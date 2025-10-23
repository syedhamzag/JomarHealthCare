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
    public class UpdateRegisterIncomeCommandValidator: AbstractValidator<UpdatePayrollSummaryCommand>
    {
        public UpdateRegisterIncomeCommandValidator()
        {
            RuleFor(c => c.StartDate)
             .NotEmpty().WithMessage("Date is required.")
             .LessThanOrEqualTo(DateTime.Now).WithMessage("Date cannot be in the future.");

            RuleFor(c => c.EndDate)
                .NotEmpty().WithMessage("EndDate is required.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Date is required.");

            RuleFor(c => c.Staff)
                .NotEmpty().WithMessage("Staff  is required.");

            RuleFor(c => c.StaffClass)
                .NotEmpty().WithMessage("Staffclass is required.");

            RuleFor(c => c.CategoryofStaff)
                .NotEmpty().WithMessage("category is required.");

            RuleFor(c => c.TypeofStaffService)
               .NotEmpty().WithMessage("staff service is required.");
        }
    }
}
