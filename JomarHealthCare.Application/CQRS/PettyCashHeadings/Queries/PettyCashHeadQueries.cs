using MediatR;
using JomarHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JomarHealthCare.Application.CQRS.PettyCashHeadings.Queries
{
    public record GetPettyHeadingCashById(int Id) : IRequest<PettyCashHeading>;

    public record GetAllPettyCashHeading() : IRequest<List<PettyCashHeading>>;

    public record GetAllPettyCashHeadingByCompanyIdQuery(Guid companyId) : IRequest<List<PettyCashHeading>>;
}
