using MediatR;
using JomarHealthCare.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Commands.RegisterReductionCommand
{
    public class UpdateRegisterReductionCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public Guid CompanayId { get; set; }
        public string DeductionName { get; set; }
    }
}
