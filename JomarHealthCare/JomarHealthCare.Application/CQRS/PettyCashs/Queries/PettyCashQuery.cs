using MediatR;
using JomarHealthCare.Application.DataModels.Hobby;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashs.Queries
{
    public record GetPettyCashById(int Id) : IRequest<PettyCash>;

    public record GetAllPettyCash() : IRequest<List<PettyCash>>;

    public record GetAllPettyCashByCompanyIdQuery(Guid companyId) : IRequest<List<PettyCash>>;
}
