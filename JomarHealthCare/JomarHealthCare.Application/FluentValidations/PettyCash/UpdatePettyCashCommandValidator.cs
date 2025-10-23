using FluentValidation;
using JomarHealthCare.Application.CQRS.PettyCashs.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.FluentValidations.PettyCash
{
    public class UpdatePayrollSummaryCommandValidator: AbstractValidator<UpdatePettyCashCommand>
    {
        public UpdatePayrollSummaryCommandValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("ID is required.");

            RuleFor(c => c.Detail)
                .NotEmpty().WithMessage("Detail is required.")
                .MaximumLength(500).WithMessage("Detail cannot exceed 500 characters.");

            RuleFor(c => c.Date)
                .NotEmpty().WithMessage("Date is required.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Date cannot be in the future.");

            RuleFor(c => c.StaffId)
                .NotEmpty().WithMessage("Staff ID is required.");

            RuleFor(c => c.MethodId)
                .NotEmpty().WithMessage("Payment method is required.");

            RuleFor(c => c.Amount)
                .NotEmpty().WithMessage("Amount is required.")
                .GreaterThan(0).WithMessage("Amount must be greater than 0.");
        }
    }
}
