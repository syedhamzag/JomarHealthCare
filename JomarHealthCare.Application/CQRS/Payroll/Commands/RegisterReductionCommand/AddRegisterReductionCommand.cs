using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterReductionCommand
{
    public class AddRegisterReductionCommand: IRequest<Domain.Entities.RegisterDeduction>
    {
        public Guid CompanyId { get; set; }
        public string DeductionName { get; set; }
    }
}
