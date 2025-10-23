using MediatR;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterIncomeCommand
{
    public class UpdateRegisterIncomeCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public string IncomeName { get; set; }
    }
}
