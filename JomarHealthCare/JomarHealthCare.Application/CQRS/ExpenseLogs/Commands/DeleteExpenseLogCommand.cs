using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Commands
{
    public class DeleteExpenseLogCommand: IRequest<bool>
    {
        public int Id { get; set; }
    }
}
