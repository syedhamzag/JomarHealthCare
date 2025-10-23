using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashs.Commands
{
    public class AddPettyCashCommand: IRequest<Domain.Entities.PettyCash>
    {
        public string Detail { get; set; }
        public DateTime? Date { get; set; }
        public Guid StaffId { get; set; }
        public int? MethodId { get; set; }
        public decimal Amount { get; set; }
    }
}
