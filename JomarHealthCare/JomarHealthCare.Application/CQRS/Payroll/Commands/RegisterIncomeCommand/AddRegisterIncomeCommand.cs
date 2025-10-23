using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterIncomeCommand
{
    public class AddRegisterIncomeCommand: IRequest<Domain.Entities.RegisterIncome>
    {
        public Guid CompanyId { get; set; }
        public string IncomeName { get; set; }
    }
}
