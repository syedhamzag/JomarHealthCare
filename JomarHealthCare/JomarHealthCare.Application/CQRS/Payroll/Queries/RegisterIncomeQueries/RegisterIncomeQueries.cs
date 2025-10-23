using MediatR;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterIncomeQueries
{
    public record GetRegisterIncomeById(int Id) : IRequest<RegisterIncome>;

    public record GetAllRegisterIncome() : IRequest<List<RegisterIncome>>;

    public record GetAllRegisterIncomeByCompanyIdQuery(Guid companyId) : IRequest<List<RegisterIncome>>;
}
