using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands
{
    public class UpdatePettyCashHeadingCommand: IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMethod { get; set; }
        public Guid CompanyId { get; set; }

    }
}
