using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Commands
{
    public class AddPettyCashHeadingCommand: IRequest<Domain.Entities.PettyCashHeading>
    {
        public string Name { get; set; }
        public bool IsMethod { get; set; }

    }
}
