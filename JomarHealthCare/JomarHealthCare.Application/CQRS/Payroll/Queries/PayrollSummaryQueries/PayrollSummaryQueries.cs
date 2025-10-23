using MediatR;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Queries
{
    public record GetPayrollSummaryById(int Id) : IRequest<PayrollSummary>;

    public record GetAllPayrollSummary() : IRequest<List<PayrollSummary>>;

    public record GetAllPayrollSummaryByCompanyIdQuery(Guid companyId) : IRequest<List<PayrollSummary>>;
}
