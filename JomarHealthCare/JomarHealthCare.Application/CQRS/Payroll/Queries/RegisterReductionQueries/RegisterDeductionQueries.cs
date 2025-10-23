using MediatR;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.Payroll.Queries.RegisterReductionQueries
{
    public record GetRegisterDeductionById(int Id) : IRequest<RegisterDeduction>;

    public record GetAllRegisterDeduction() : IRequest<List<RegisterDeduction>>;

    public record GetAllRegisterDeductionByCompanyIdQuery(Guid companyId) : IRequest<List<RegisterDeduction>>;
}
