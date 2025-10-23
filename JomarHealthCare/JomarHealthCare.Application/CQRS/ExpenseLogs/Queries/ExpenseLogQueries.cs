using MediatR;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.ExpenseLogs.Queries
{
    public record GetExpenseLogById(int Id) : IRequest<Expenselog>;

    public record GetAllExpenseLog() : IRequest<List<Expenselog>>;

    public record GetAllExpenselogByCompanyIdQuery(Guid companyId) : IRequest<List<Expenselog>>;
}
