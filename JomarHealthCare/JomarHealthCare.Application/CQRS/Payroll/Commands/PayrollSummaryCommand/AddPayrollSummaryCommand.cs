using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.PayrollSummaryCommand
{
    public class AddPayrollSummaryCommand: IRequest<Domain.Entities.PayrollSummary>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CategoryofStaff { get; set; }
        public int? TypeofStaffService { get; set; }
        public int? StaffClass { get; set; }
        public string Staff { get; set; }
    }
}
