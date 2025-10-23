using MediatR;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.CompanyBanks.Queries
{
    public record GetCompanyBankById(int Id) : IRequest<CompanyBank>;

    public record GetAllCompanyBank() : IRequest<List<CompanyBank>>;

    public record GetAllCompanyBankByCompanyIdQuery(Guid companyId) : IRequest<List<CompanyBank>>;
}
