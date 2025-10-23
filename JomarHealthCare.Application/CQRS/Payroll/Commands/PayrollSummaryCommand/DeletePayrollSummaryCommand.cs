using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand
{
    public class DeletePayrollSummaryCommand: IRequest<bool>
    {
        public int Id { get; set; }
    }
}
